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
    $stderrFile = [System.IO.Path]::GetTempFileName()
    $p = $ErrorActionPreference; $ErrorActionPreference = 'Continue'
    try { & $exe $PdfPath -o $CachedMarkdown 2>$stderrFile | Out-Null } finally { $ErrorActionPreference = $p }
    $exit = $LASTEXITCODE
    $stderr = if (Test-Path -LiteralPath $stderrFile) { (Get-Content -LiteralPath $stderrFile -Raw) } else { '' }
    Remove-Item -LiteralPath $stderrFile -ErrorAction SilentlyContinue
    if (-not (Test-Path -LiteralPath $CachedMarkdown) -or (Get-Item $CachedMarkdown).Length -lt 1024) {
        $hint = if ($stderr -match 'MissingDependencyException|\[pdf\]') {
            "`n`nHint: markitdown is missing its PDF backend. Install with:`n  uv pip install 'markitdown[pdf]'   # or: pip install 'markitdown[pdf]'"
        } else { '' }
        $detail = if ($stderr) { "`n`nmarkitdown stderr (exit $exit):`n$stderr" } else { " (markitdown exit $exit)" }
        throw "Conversion failed or produced too little output.$detail$hint"
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
# Page-noise cleanup. markitdown emits each PDF page break as three lines:
#   <footer>                                (page number + "Developed by Strand7 Pty Limited",
#                                            in either order depending on odd/even page)
#   <blank>
#   <header>                                (either "Strand7 API Manual" on right-hand pages
#                                            or the current section name on left-hand pages)
# When a function's documentation wraps across a page, this whole 3-line block
# lands in the middle of the buffered body. Strip it as a unit so surrounding
# text reflows cleanly.
$pageNumPat = '(?:\d{1,4}|[ivxlcdm]+)'
$footerPat  = "(?:$pageNumPat[ \t]+Developed by Strand7 Pty Limited|Developed by Strand7 Pty Limited[ \t]+$pageNumPat)"
# Table-footer form: a markdown table row containing the footer text, and an
# optional separator row directly beneath (which markitdown emits when the
# footer stands alone as a fake single-row table).
$tableFooterPat = "\|[^\r\n]*Developed by Strand7 Pty Limited[^\r\n]*\|[^\r\n]*(?:\r?\n\|(?:\s*:?-+:?\s*\|)+)?"
# Page-boundary block. After the footer we drop the blank line, one header
# line, and an optional duplicate of that header line (which occurs when the
# next PDF page begins a new section — the section title lands twice on the
# page, once as the running header and once as an inline heading).
$noiseBlockRx  = [regex]"(?m)^$footerPat[ \t]*\r?\n(?:[ \t]*\r?\n)+([^\r\n]+)(?:\r?\n\1)?(?:\r?\n|\z)"
$noiseFooterRx = [regex]"(?m)^$footerPat[ \t]*\r?\n?"
$noiseHeaderRx = [regex]'(?m)^\s*Strand7 API Manual\s*\r?\n?'
# Same block form, but where the footer landed inside a markdown table.
$noiseTableBlockRx = [regex]"(?m)^$tableFooterPat\r?\n(?:[ \t]*\r?\n)*([^\r\n]+)(?:\r?\n\1)?(?:\r?\n|\z)"
$noiseTableRx      = [regex]"(?m)^$tableFooterPat\r?\n?"
$current = $null
$buffer = [System.Collections.Generic.List[string]]::new()
$emitted = 0
function Save-Section {
    param(
        [string] $Name,
        [System.Collections.Generic.List[string]] $Body,
        [string] $OutDir,
        [regex]  $BlockRx,
        [regex]  $FooterRx,
        [regex]  $HeaderRx,
        [regex]  $TableBlockRx,
        [regex]  $TableRx
    )
    if (-not $Name) { return 0 }
    while ($Body.Count -gt 0 -and [string]::IsNullOrWhiteSpace($Body[0]))               { $Body.RemoveAt(0) }
    while ($Body.Count -gt 0 -and [string]::IsNullOrWhiteSpace($Body[$Body.Count - 1])) { $Body.RemoveAt($Body.Count - 1) }
    if ($Body.Count -eq 0) { return 0 }
    $text = ($Body -join "`r`n")
    $text = $TableBlockRx.Replace($text, "`r`n")
    $text = $BlockRx.Replace($text, "`r`n")
    $text = $TableRx.Replace($text, '')
    $text = $FooterRx.Replace($text, '')
    $text = $HeaderRx.Replace($text, '')
    # Ensure a blank line separates the description paragraph from the C-style
    # signature. markitdown sometimes emits them on consecutive lines when the
    # PDF page didn't break between them, and Inject-XmlDocs takes the "first
    # paragraph" (up to the first blank line) as the <summary>. Without this
    # gap, the signature ends up glued onto the summary of functions like
    # St7Release. The following (\r?\n){3,} collapse pass will normalise any
    # accidental double-blanks introduced here.
    $text = [regex]::Replace($text, "(?m)^long\s+St7[A-Za-z0-9_]+\s*\(", "`r`n$&")
    $text = [regex]::Replace($text, "(\r?\n){3,}", "`r`n`r`n").Trim()
    $md = "# $Name`r`n`r`n$text`r`n"
    [System.IO.File]::WriteAllText((Join-Path $OutDir ("{0}.md" -f $Name)), $md, [System.Text.UTF8Encoding]::new($false))
    return 1
}
$seenNames = [System.Collections.Generic.HashSet[string]]::new()
# Chapter titles that mark the start of appendix/reference sections coming
# AFTER the function reference chapter (Type Definitions, Error Codes, etc.).
# The manual body doesn't reuse any of these as inline headings inside a
# function's docs, so encountering one is an unambiguous signal that the
# current function's documentation has ended.
$appendixMarkers = [System.Collections.Generic.HashSet[string]]::new()
foreach ($h in @(
    'Type Definitions',
    'Error Codes',
    'Element Connections',
    'User Defined Material Matrix',
    'Attribute Types',
    'Beam Cross Section Shapes',
    'Beam Cross Section Mirror Options',
    'Beam Distributed Load Types',
    'Link Types',
    'Load Patch Types',
    'Grade Types',
    'Table Types',
    'Solver Options',
    'Node Results',
    'Beam Results',
    'Plate Results',
    'User Defined Results',
    'Creep Definitions',
    'Model Window Components',
    'RGB Colours',
    'Entity Contours',
    'Result Display Options',
    'Custom Results',
    'Strand7 Function Index'
)) { [void]$appendixMarkers.Add($h) }
# Look-ahead window used to distinguish a function-reference heading from a
# bare mention of the function name in tutorial code, index tables, or
# diagrams. Every real reference is followed within a few lines by the
# C-style signature "long St7Xxx(...)"; tutorial mentions are not.
$sigLookahead = 15
for ($i = 0; $i -lt $lines.Count; $i++) {
    $line = $lines[$i]
    $t = $line.Trim()
    if ($appendixMarkers.Contains($t)) {
        if ($current) {
            $emitted += (Save-Section $current $buffer $OutputDir $noiseBlockRx $noiseFooterRx $noiseHeaderRx $noiseTableBlockRx $noiseTableRx)
            $current = $null
            $buffer.Clear()
        }
        continue
    }
    if ($names.Contains($t)) {
        $sigRx = '^\s*long\s+' + [regex]::Escape($t) + '\s*\('
        $isReference = $false
        $limit = [Math]::Min($lines.Count - 1, $i + $sigLookahead)
        for ($k = $i + 1; $k -le $limit; $k++) {
            if ($lines[$k] -match $sigRx) { $isReference = $true; break }
        }
        if (-not $isReference) {
            # Bare function-name mention with no signature follow-up. Two
            # variants exist in the manual:
            #   1. Tutorial code (e.g. "St7Release" as a VBA call, appearing
            #      before any real reference has started — $current is null).
            #   2. Ancillary-section diagram/index cell (e.g. "Model Window
            #      Components" or the trailing "Strand7 Function Index") that
            #      comes AFTER the last legitimate reference. Every such
            #      mention marks the boundary between the function reference
            #      chapter and the appendices, so flush and stop capturing.
            if ($current) {
                $emitted += (Save-Section $current $buffer $OutputDir $noiseBlockRx $noiseFooterRx $noiseHeaderRx $noiseTableBlockRx $noiseTableRx)
                $current = $null
                $buffer.Clear()
            }
            continue
        }
        if ($seenNames.Contains($t)) {
            # Defensive: the manual documents each function once. If a second
            # heading still slips through, flush and stop capturing rather
            # than overwrite the first (good) page.
            $emitted += (Save-Section $current $buffer $OutputDir $noiseBlockRx $noiseFooterRx $noiseHeaderRx $noiseTableBlockRx $noiseTableRx)
            $current = $null
            $buffer.Clear()
            continue
        }
        $emitted += (Save-Section $current $buffer $OutputDir $noiseBlockRx $noiseFooterRx $noiseHeaderRx $noiseTableBlockRx $noiseTableRx)
        [void]$seenNames.Add($t)
        $current = $t
        $buffer.Clear()
        continue
    }
    if ($current) { [void]$buffer.Add($line) }
}
$emitted += (Save-Section $current $buffer $OutputDir $noiseBlockRx $noiseFooterRx $noiseHeaderRx $noiseTableBlockRx $noiseTableRx)
$missing = @($names | Where-Object { -not (Test-Path -LiteralPath (Join-Path $OutputDir "$_.md")) })
Write-Host ("Wrote {0} function pages to {1}" -f $emitted, (Resolve-Path $OutputDir)) -ForegroundColor Green
if ($missing.Count -gt 0) {
    Write-Host ("{0} P/Invoke functions had no matching section in the PDF (first 10):" -f $missing.Count) -ForegroundColor Yellow
    $missing | Select-Object -First 10 | ForEach-Object { "  $_" }
}
