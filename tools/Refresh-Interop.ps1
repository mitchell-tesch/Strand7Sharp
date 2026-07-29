<#
.SYNOPSIS
    End-to-end refresh of the Strand7 P/Invoke surface from a Strand7 install.

.DESCRIPTION
    Runs the full four-step pipeline in order:

      1. Copy    C:\Program Files\Strand7 R31\API Includes\Visual C#\St7API.cs
              -> Strand7Sharp\Interop\St7API.cs                (fresh install copy)
      2. Convert Strand7 R3 API Manual.pdf -> docs\api\St7*.md  (Convert-ApiManual.ps1)
      3. Inject  docs\api\*.md            -> <summary> blocks   (Inject-XmlDocs.ps1)
      4. Generate St7API.cs               -> St7Native.g.cs      (Generate-Wrapper.ps1)

    Use this whenever a new Strand7 release ships. Each sub-script is
    idempotent; the copy step just replaces the annotated interop file with
    the raw install copy so step (3) can re-inject the summaries from the
    freshly-regenerated markdown.

.PARAMETER InstallDir
    Root of the Strand7 install. Defaults to 'C:\Program Files\Strand7 R31'.
    The interop and PDF paths below are derived from this if not supplied
    explicitly.

.PARAMETER InstallInteropFile
    Full path to the install's St7API.cs. Defaults to
    "$InstallDir\API Includes\Visual C#\St7API.cs".

.PARAMETER InstallPdf
    Full path to the install's API manual PDF. Defaults to
    "$InstallDir\Documentation\Strand7 R3 API Manual.pdf".

.PARAMETER InteropFile
    Repo-side interop file to overwrite and re-annotate. Defaults to
    Strand7Sharp\Interop\St7API.cs.

.PARAMETER DocsDir
    Per-function markdown output directory. Defaults to docs\api.

.PARAMETER OutputFile
    Generated wrapper file. Defaults to Strand7Sharp\Generated\St7Native.g.cs.

.PARAMETER CachedMarkdown
    Cached full-manual markdown used by Convert-ApiManual.ps1. Defaults to
    tools\api-manual.md.

.PARAMETER Force
    Forwarded to Convert-ApiManual.ps1 to force a fresh PDF -> markdown
    conversion. Without this the cached markdown is reused. Pass this when
    the install ships a new PDF.

.EXAMPLE
    pwsh tools/Refresh-Interop.ps1
    # Uses the cached markdown, refreshes everything else.

.EXAMPLE
    pwsh tools/Refresh-Interop.ps1 -Force
    # Also re-runs markitdown on the install PDF.

.EXAMPLE
    pwsh tools/Refresh-Interop.ps1 -InstallDir 'C:\Program Files\Strand7 R32'
    # Refresh from a different Strand7 install location.
#>
[CmdletBinding()]
param(
    [string] $InstallDir         = 'C:\Program Files\Strand7 R31',
    [string] $InstallInteropFile,
    [string] $InstallPdf,
    [string] $InteropFile        = (Join-Path $PSScriptRoot '..\Strand7Sharp\Interop\St7API.cs'),
    [string] $DocsDir            = (Join-Path $PSScriptRoot '..\docs\api'),
    [string] $OutputFile         = (Join-Path $PSScriptRoot '..\Strand7Sharp\Generated\St7Native.g.cs'),
    [string] $CachedMarkdown     = (Join-Path $PSScriptRoot 'api-manual.md'),
    [switch] $Force
)

$ErrorActionPreference = 'Stop'

if (-not $InstallInteropFile) { $InstallInteropFile = Join-Path $InstallDir 'API Includes\Visual C#\St7API.cs' }
if (-not $InstallPdf)         { $InstallPdf         = Join-Path $InstallDir 'Documentation\Strand7 R3 API Manual.pdf' }

function Write-Step {
    param([int] $Number, [string] $Message)
    Write-Host ""
    Write-Host ("[{0}/4] {1}" -f $Number, $Message) -ForegroundColor Cyan
}

function Count-Pinvokes {
    param([string] $Path)
    if (-not (Test-Path -LiteralPath $Path)) { return 0 }
    $rx = 'public\s+static\s+extern\s+\w+\s+(St7[A-Za-z0-9_]+)\s*\('
    return [regex]::Matches((Get-Content -LiteralPath $Path -Raw), $rx).Count
}

if (-not (Test-Path -LiteralPath $InstallInteropFile)) {
    throw "Install St7API.cs not found: $InstallInteropFile`n" +
          "Pass -InstallDir or -InstallInteropFile to point at your Strand7 install."
}
if (-not (Test-Path -LiteralPath $InstallPdf)) {
    throw "Install API manual PDF not found: $InstallPdf`n" +
          "Pass -InstallDir or -InstallPdf to point at your Strand7 install."
}

Write-Host "Strand7Sharp interop refresh" -ForegroundColor Green
Write-Host ("  install interop : {0}" -f $InstallInteropFile) -ForegroundColor DarkGray
Write-Host ("  install PDF     : {0}" -f $InstallPdf)         -ForegroundColor DarkGray
Write-Host ("  repo interop    : {0}" -f $InteropFile)        -ForegroundColor DarkGray
Write-Host ("  docs dir        : {0}" -f $DocsDir)            -ForegroundColor DarkGray
Write-Host ("  wrapper output  : {0}" -f $OutputFile)         -ForegroundColor DarkGray

# ---------------------------------------------------------------- 1/4 copy
Write-Step 1 "Copying install St7API.cs -> repo interop file"

$fnsBefore = Count-Pinvokes $InteropFile
$parent = Split-Path -Parent $InteropFile
if ($parent -and -not (Test-Path -LiteralPath $parent)) {
    New-Item -ItemType Directory -Force -Path $parent | Out-Null
}
Copy-Item -LiteralPath $InstallInteropFile -Destination $InteropFile -Force
$fnsAfter = Count-Pinvokes $InteropFile
Write-Host ("      P/Invoke count: {0} -> {1}" -f $fnsBefore, $fnsAfter) -ForegroundColor DarkGray

# ---------------------------------------------------------------- 2/4 PDF -> md
Write-Step 2 ("Converting API manual PDF -> per-function markdown" +
              $(if ($Force) { ' (-Force: re-running markitdown)' } else { ' (reusing cached markdown if present)' }))

$convertArgs = @{
    PdfPath        = $InstallPdf
    OutputDir      = $DocsDir
    InteropFile    = $InteropFile
    CachedMarkdown = $CachedMarkdown
}
if ($Force) { $convertArgs.Force = $true }
& (Join-Path $PSScriptRoot 'Convert-ApiManual.ps1') @convertArgs

# ---------------------------------------------------------------- 3/4 inject
Write-Step 3 "Injecting <summary> XML docs into interop file"
& (Join-Path $PSScriptRoot 'Inject-XmlDocs.ps1') `
    -InteropFile $InteropFile `
    -DocsDir     $DocsDir

# ---------------------------------------------------------------- 4/4 generate
Write-Step 4 "Regenerating St7Native.g.cs wrapper"
& (Join-Path $PSScriptRoot 'Generate-Wrapper.ps1') `
    -InteropFile $InteropFile `
    -OutputFile  $OutputFile

Write-Host ""
Write-Host "Refresh complete." -ForegroundColor Green
Write-Host "Review the diff with 'git status' / 'git diff' and commit if the changes look right." -ForegroundColor DarkGray
