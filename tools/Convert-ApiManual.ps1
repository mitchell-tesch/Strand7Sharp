param(
    [string] $PdfPath = 'C:\Program Files\Strand7 R31\Documentation\Strand7 R3 API Manual.pdf',
    [string] $OutputDir = (Join-Path $PSScriptRoot '..\docs\api'),
    [string] $InteropFile = (Join-Path $PSScriptRoot '..\Strand7Sharp\Interop\St7API.cs'),
    [string] $CachedMarkdown = (Join-Path $PSScriptRoot 'api-manual.md'),
    [switch] $Force
)
$ErrorActionPreference = 'Stop'
if (-not (Test-Path -LiteralPath $InteropFile)) { throw "Interop file not found: $InteropFile" }
New-Item -ItemType Directory -Force -Path $OutputDir | Out-Null
if ($Force -or -not (Test-Path -LiteralPath $CachedMarkdown)) {
    if (-not (Test-Path -LiteralPath $PdfPath)) { throw "PDF not found at '$PdfPath'." }
    $venvMd = Join-Path $PSScriptRoot '..\.venv\Scripts\markitdown.exe'
    $exe = if (Test-Path -LiteralPath $venvMd) { $venvMd }
           elseif (Get-Command markitdown -ErrorAction SilentlyContinue) { (Get-Command markitdown).Source }
           else { throw 'markitdown not found.' }
    Write-Host "Converting PDF -> $CachedMarkdown using $exe ..." -ForegroundColor Cyan
    $p = $ErrorActionPreference; $ErrorActionPreference = 'Continue'
    try { & $exe $PdfPath -o $CachedMarkdown 2>$null | Out-Null } finally { $ErrorActionPreference = $p }
    if (-not (Test-Path -LiteralPath $CachedMarkdown) -or (Get-Item $CachedMarkdown).Length -lt 1024) {
        throw "Conversion failed or produced too little output."
    }
} else {
    Write-Host "Reusing cached markdown $CachedMarkdown (pass -Force to re-convert)." -ForegroundColor DarkGray
}
$interop = Get-Content -LiteralPath $InteropFile -Raw
$names = [System.Collections.Generic.HashSet[string]]::new()
foreach ($m in [regex]::Matches($interop, 'public\s+static\s+extern\s+\w+\s+(St7[A-Za-z0-9_]+)\s*\(')) {
    [void]$names.Add($m.Groups[1].Value)
}
Write-Host "Found $($names.Count) P/Invoke functions in $InteropFile" -ForegroundColor DarkGray
$lines = Get-Content -LiteralPath $CachedMarkdown -Encoding utf8
$noiseRx = [regex]"(?m)^(Developed by Strand7 Pty Limited|Strand7 Pty Limited|API Manual|File Management|Initialisation|Model Window)\s*$|^\s*\d{1,4}\s*$"
$current = $null
$buffer = [System.Collections.Generic.List[string]]::new()
$emitted = 0
function Save-Section {
    param([string] $Name, [System.Collections.Generic.List[string]] $Body, [string] $OutDir)
    if (-not $Name) { return 0 }
    while ($Body.Count -gt 0 -and [string]::IsNullOrWhiteSpace($Body[0]))               { $Body.RemoveAt(0) }
    while ($Body.Count -gt 0 -and [string]::IsNullOrWhiteSpace($Body[$Body.Count - 1])) { $Body.RemoveAt($Body.Count - 1) }
    if ($Body.Count -eq 0) { return 0 }
    $text = ($Body -join "`r`n")
    $text = ([regex]"(?m)^(Developed by Strand7 Pty Limited|Strand7 Pty Limited|API Manual|File Management|Initialisation|Model Window)\s*$|^\s*\d{1,4}\s*$").Replace($text, '')
    $text = [regex]::Replace($text, "(\r?\n){3,}", "`r`n`r`n").Trim()
    $md = "# $Name`r`n`r`n$text`r`n"
    [System.IO.File]::WriteAllText((Join-Path $OutDir ("{0}.md" -f $Name)), $md, [System.Text.UTF8Encoding]::new($false))
    return 1
}
foreach ($line in $lines) {
    $t = $line.Trim()
    if ($names.Contains($t)) {
        $emitted += (Save-Section $current $buffer $OutputDir)
        $current = $t
        $buffer.Clear()
        continue
    }
    if ($current) { [void]$buffer.Add($line) }
}
$emitted += (Save-Section $current $buffer $OutputDir)
$missing = @($names | Where-Object { -not (Test-Path -LiteralPath (Join-Path $OutputDir "$_.md")) })
Write-Host ("Wrote {0} function pages to {1}" -f $emitted, (Resolve-Path $OutputDir)) -ForegroundColor Green
if ($missing.Count -gt 0) {
    Write-Host ("{0} P/Invoke functions had no matching section in the PDF (first 10):" -f $missing.Count) -ForegroundColor Yellow
    $missing | Select-Object -First 10 | ForEach-Object { "  $_" }
}
