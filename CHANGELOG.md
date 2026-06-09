# Changelog

All notable changes to **Strand7Sharp** are documented in this file.

The format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and the project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

## [0.1.0] - 2026-06-09

Initial public release.

### Added
- **Three-layer architecture** over the Strand7 R3 API (`St7API.dll`):
  - **Layer 1** — `St7API.St7`: verbatim copy of the official P/Invoke
    surface (`int` return codes, `ref` / `StringBuilder` parameters).
  - **Layer 2** — `Strand7Sharp.St7Native`: 1918 auto-generated managed
    wrappers. Every call throws `St7Exception` on a non-zero result,
    promotes `ref` parameters to `ValueTuple` returns, and collapses the
    `(StringBuilder, int MaxStringLen)` idiom into `string` returns.
  - **Layer 3** — `Strand7Sharp.*`: hand-curated, allocation-free
    `readonly struct` facets off `St7Model` covering the common 80% of
    workflows.
- **Layer 3 facet coverage:**
  - Session lifecycle: `Strand7Api.Initialize` (singleton `St7Init` /
    `St7Release`), `OpenModel` / `OpenModelReadOnly` / `NewModel` with
    auto-allocated `FileId`s, `Strand7Api.Settings`
    (`ApplicationSettings` + `UseSolverDll`).
  - Mesh entities: `Nodes`, `Beams`, `Plates`, `Bricks`, `Links` — full
    CRUD plus the day-to-day attribute set (XYZ, connection, property,
    group, restraints, forces, springs, masses, temperatures, pressures,
    edge / end releases, offsets, orientation).
  - Geometry entities: `Vertices`, `GeometryFaces`, `GeometryEdges`,
    `LoadPaths`.
  - Cases & staging: `LoadCases`, `FreedomCases`, `Stages`,
    `NLAIncrements`.
  - Coordinate systems & grouping: `UCS`, `Groups`, `EntitySets`.
  - Properties / tables / layouts: `BeamProperties`, `PlateProperties`,
    `BrickProperties` with library look-ups, strongly-typed `Tables`,
    `Layouts.Laminates`, `Layouts.Reinforcements`, `CavityFluids`.
  - Solver: in-process `Solver.Run(...)` and out-of-process
    `Solver.RunProcess(...)` for the full St7 solver suite.
  - Results: `model.OpenResults(...)` → `St7Results` for primary case
    enumeration and node / beam / plate / brick result extraction.
  - Tooling, UI & metadata: `Selection`, `Tools`, `Window`, `General`
    (titles, project, author, comments, `ResultCombinations`).
- **Generators (PowerShell):**
  - `tools/Convert-ApiManual.ps1` — Strand7 R3 API Manual PDF →
    `docs/api/St7*.md` per-function pages (via `markitdown`).
  - `tools/Inject-XmlDocs.ps1` — markdown → `<summary>` XML doc comments
    above every `[DllImport]` in `Interop/St7API.cs`.
  - `tools/Generate-Wrapper.ps1` — `Interop/St7API.cs` →
    `Generated/St7Native.g.cs` (1918 wrappers).
- **NuGet packaging:**
  - 128×128 package icon (`<PackageIcon>icon.png</PackageIcon>`),
    rendered from `assets/icon.svg` via the throwaway
    `tools/IconRender` console.
  - Bundled README (`<PackageReadmeFile>README.md</PackageReadmeFile>`).
  - Per-function manual pages shipped at `docs/api/*.md` inside the
    package so consumers / agents can read the source-of-truth
    documentation locally.
  - SourceLink (GitHub) wired in; deterministic build flags;
    `EmbedUntrackedSources=true` so generated sources step-into.
  - Symbol package (`.snupkg`) emitted alongside every `.nupkg`.
- **Multi-targeted** for `net8.0-windows` and `net48`. `St7API.dll`
  itself is **not** redistributed — consumers supply it from a licensed
  Strand7 R3 install.

[Unreleased]: https://github.com/mitchell-tesch/Strand7Sharp/compare/v0.1.0...HEAD
[0.1.0]: https://github.com/mitchell-tesch/Strand7Sharp/releases/tag/v0.1.0

