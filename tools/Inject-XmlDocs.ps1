<#
.SYNOPSIS
    Injects <summary> XML doc comments above each P/Invoke in
    Strand7Sharp/Interop/St7API.cs, sourced from docs/api/<Function>.md.

.DESCRIPTION
    For each `public static extern int St7Foo(...);` line in the interop file,
    look for `docs/api/St7Foo.md`. If found, take the first non-empty
    paragraph (after the leading `# St7Foo` heading) and emit it as a
    `/// <summary>...</summary>` comment on the line directly above the
    [DllImport] attribute.

    The script is idempotent: it removes any pre-existing block of comments
    immediately above each [DllImport(...)] (whether `///` or `//`) before
    re-emitting them, so re-running after the docs change just refreshes
    them.

.PARAMETER InteropFile
    Path to the P/Invoke file to annotate. Defaults to
    Strand7Sharp/Interop/St7API.cs.

.PARAMETER DocsDir
    Directory holding the per-function markdown files. Defaults to docs/api.

.EXAMPLE
    pwsh tools/Inject-XmlDocs.ps1
#>
[CmdletBinding()]
param(
    [string] $InteropFile = (Join-Path $PSScriptRoot '..\Strand7Sharp\Interop\St7API.cs'),
    [string] $DocsDir     = (Join-Path $PSScriptRoot '..\docs\api')
)

$ErrorActionPreference = 'Stop'

if (-not (Test-Path -LiteralPath $InteropFile)) { throw "Interop file not found: $InteropFile" }
if (-not (Test-Path -LiteralPath $DocsDir))     { throw "Docs dir not found: $DocsDir"     }

# Build a hash of FunctionName -> first paragraph summary.
$summaries = @{}
foreach ($md in Get-ChildItem -LiteralPath $DocsDir -Filter '*.md' -File) {
    $name = [System.IO.Path]::GetFileNameWithoutExtension($md.Name)
    # Always read as UTF-8 - Windows PowerShell 5 otherwise defaults to the
    # active ANSI code page and mangles curly quotes / em-dashes into mojibake.
    $text = [System.IO.File]::ReadAllText($md.FullName, [System.Text.UTF8Encoding]::new($false))

    # Strip the leading `# St7Foo` heading.
    $text = $text -replace "^\s*#\s*$name\s*[\r\n]+", ''

    # Take everything up to the first blank line as the summary paragraph.
    $para = ($text -split "(\r?\n){2,}", 2)[0].Trim()

    if ([string]::IsNullOrWhiteSpace($para)) { continue }

    # XML-encode entities and collapse runs of whitespace.
    $para = $para -replace '&', '&amp;' -replace '<', '&lt;' -replace '>', '&gt;'
    $para = ($para -split "\r?\n" | ForEach-Object { $_.Trim() }) -join ' '
    $para = ($para -replace '\s{2,}', ' ').Trim()

    if ($para.Length -gt 0) { $summaries[$name] = $para }
}

if ($summaries.Count -eq 0) {
    Write-Warning "No markdown summaries found under $DocsDir. Run Convert-ApiManual.ps1 first."
    return
}

$src = [System.IO.File]::ReadAllText($InteropFile, [System.Text.UTF8Encoding]::new($false))
$lines = [System.Collections.Generic.List[string]]::new()
$lines.AddRange([string[]]($src -split "\r?\n"))

$externRegex = '^\s*public\s+static\s+extern\s+\w+\s+(St7[A-Za-z0-9_]+)\s*\('
$dllImportRegex = '^\s*\[DllImport\('

$out = [System.Collections.Generic.List[string]]::new()
$injected = 0

for ($i = 0; $i -lt $lines.Count; $i++) {
    $line = $lines[$i]

    # Look for a P/Invoke method line; doc the [DllImport(...)] line above it.
    if ($line -match $externRegex) {
        $fn = $Matches[1]

        # Find the [DllImport(...)] immediately above (skip blank lines).
        $dllIdx = -1
        for ($j = $out.Count - 1; $j -ge 0; $j--) {
            $t = $out[$j].TrimEnd()
            if ([string]::IsNullOrWhiteSpace($t)) { continue }
            if ($t -match $dllImportRegex) { $dllIdx = $j }
            break
        }

        if ($dllIdx -ge 0 -and $summaries.ContainsKey($fn)) {
            # Strip any pre-existing leading comments (/// or //) directly above the [DllImport].
            $k = $dllIdx - 1
            while ($k -ge 0) {
                $t = $out[$k].TrimStart()
                if ($t.StartsWith('///') -or $t.StartsWith('//')) { $out.RemoveAt($k); $dllIdx-- ; $k-- }
                else { break }
            }

            $indent = ($out[$dllIdx] -replace '\S.*$', '')
            $summary = $summaries[$fn]
            $docLines = [string[]]@(
                "$indent/// <summary>",
                "$indent/// $summary",
                "$indent/// </summary>"
            )
            $out.InsertRange($dllIdx, $docLines)
            $injected++
        }
    }

    $out.Add($line)
}

[System.IO.File]::WriteAllText($InteropFile, ($out -join "`n"), [System.Text.UTF8Encoding]::new($false))
Write-Host "Injected $injected XML doc summaries into $InteropFile" -ForegroundColor Green


