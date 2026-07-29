# AGENTS.md — Strand7Sharp

A C# wrapper around the Windows-only **Strand7 R3 API** (`St7API.dll`).
The repo is organised as **three concentric layers** — pick the lowest one that
exposes what you need.

## Architecture: three layers, one DLL

| Layer | Namespace | File(s) | Use when |
| --- | --- | --- | --- |
| 1. Raw P/Invoke | `St7API.St7` | `Strand7Sharp/Interop/St7API.cs` | The OO/native layers don't expose it. Returns `int`; uses `ref`, `StringBuilder`. |
| 2. Generated wrappers (1918 fns) | `Strand7Sharp.St7Native` | `Strand7Sharp/Generated/St7Native.g.cs` (**auto-generated, do not edit**) | You need any API call with idiomatic returns + exceptions. |
| 3. Hand-curated OO surface | `Strand7Sharp.*` (`St7Model`, `Node`, …) | `Strand7Sharp/Core/`, `Strand7Sharp/Domain/` | The common 80% — adding a missing facet is the usual feature work. |

Data flow: consumer → `Strand7Api` (singleton, `St7Init`/`St7Release`) → `St7Model`
(holds the `FileId`/uID passed to every St7 call) → facet structs (`Nodes`,
`Beams`, `Solver`, …) → `St7Native` → `St7.*` P/Invoke → `St7API.dll`.

## Non-obvious conventions

- **Errors are exceptions.** Every Layer-2/3 call funnels through
  `St7Check.Check(int, [CallerMemberName])` (`Core/St7.cs`) which throws
  `St7Exception` (decoded via `St7GetAPIErrorString`). Never check return codes
  in Layer 2/3 — just call and let it throw.
- **Facets are `readonly struct`s** holding only `(St7Model _m)`. They're created
  on every property access (`model.Nodes` is allocation-free). New collections
  should follow `Domain/Nodes.cs` exactly: a `XxxCollection` struct with
  `Count`/`this[int]`/`Add`, and an `Xxx` struct exposing per-entity ops.
- **IDs are 1-based** everywhere (nodes, load cases, freedom cases, UCS, …),
  matching Strand7 itself. `Add(...)` returns the new 1-based number, typically
  computed as `St7GetTotal(...) + 1`.
- **`ref` params → tuple returns; `(StringBuilder, MaxLen)` → `string` returns.**
  The generator (`tools/Generate-Wrapper.ps1`) recognises the
  `(StringBuilder sb, int Max(String)?Len|BufferLen|StrLen|Length)` idiom and
  collapses it. Tuple element names come from the original parameter names
  (e.g. `St7Version()` returns `(int Major, int Minor, int Point)`).
- **Booleans cross the boundary as `byte` (`St7.btTrue`/`btFalse`)**, not `bool`
  — see `SolverApi.Run` and `Solver.SetDefaultBool`.
- **Constants live in raw `St7`** (e.g. `St7.tyNODE`, `St7.kMaxStrLen`,
  `St7.ipLENGTHU`). Wrap them in `enum`s under `Core/Enums.cs` when surfacing
  them in Layer 3 (see `EntityType`, `SolverType`, `Strand7Units`).
- **Per-function manual pages** under `docs/api/St7*.md` are the source of truth
  for behaviour. Their first paragraph is auto-injected as the `<summary>` on
  each `[DllImport]` by `Inject-XmlDocs.ps1`. When implementing a wrapper,
  read `docs/api/<FunctionName>.md` first (see `docs/AGENTS.md`).
- **Naming preserves the `St7` prefix in Layer 2** so every method maps 1:1 to
  its doc page (`St7Native.St7GetNodeXYZ`, not `GetNodeXYZ`). Layer 3 drops it.
- **Layer-3 facet surface** (off `St7Model`): entities — `Nodes`, `Beams`,
  `Plates`, `Bricks`, `Links`, `Vertices`, `GeometryFaces`, `GeometryEdges`,
  `LoadPaths`; cases & coords — `LoadCases`, `FreedomCases`, `UCS`, `Groups`,
  `EntitySets`, `Stages`; properties/tables — `BeamProperties`,
  `PlateProperties`, `BrickProperties`, `Tables`, `Layouts` (with
  `.Laminates` / `.Reinforcements`); solver/results/tools/general — `Solver`,
  `Selection`, `Tools`, `General` (titles, comments, ResultCombinations),
  plus `OpenResults(...)` for `St7Results`. App-level settings live on
  `Strand7Api.Settings` (`ApplicationSettings` — global int/bool/string slots,
  `UseSolverDll`).
- **Bool ↔ byte:** use `St7Check.AsByte(bool)` when passing a managed `bool`
  to a `byte` parameter of a `St7Native.*` wrapper. `St7.btTrue`/`btFalse` are
  `int` and do **not** auto-cast.

## Workflows (PowerShell — repo is Windows-only, `net8.0-windows;net48`)

```powershell
pwsh tools/Refresh-Interop.ps1       # all-in-one: fresh install St7API.cs + docs + wrapper (use after a Strand7 upgrade; pass -Force to re-run markitdown)
pwsh tools/Convert-ApiManual.ps1     # Strand7 R3 API Manual.pdf -> docs/api/St7*.md (needs markitdown[pdf] in .venv)
pwsh tools/Inject-XmlDocs.ps1        # docs/api/*.md -> <summary> above each [DllImport] in St7API.cs (idempotent)
pwsh tools/Generate-Wrapper.ps1      # St7API.cs  -> Strand7Sharp/Generated/St7Native.g.cs (1918 wrappers, idempotent)
dotnet build -c Release
dotnet pack  -c Release              # ships docs/api/*.md inside the NuGet package
```

`Refresh-Interop.ps1` runs the last three in order after copying the raw
`St7API.cs` from `C:\Program Files\Strand7 R31\API Includes\Visual C#\` over
the repo copy — that's the intended way to roll forward a new Strand7 release.
Running the individual scripts on their own is still fine; each is idempotent.

The PDF is **not** redistributed — see `docs/AGENTS.md` for the rationale and
the agent rule ("read `docs/api/<FunctionName>.md` before calling any St7
function"). Don't hand-edit `Generated/St7Native.g.cs` or the regenerated
`<summary>` blocks in `Interop/St7API.cs` — fix the generator or the markdown.

## Adding a new Layer-3 facet (typical task)

1. Identify the St7 functions and read each `docs/api/St7*.md`.
2. Add a `XxxCollection` + `Xxx` pair in `Strand7Sharp/Domain/Xxx.cs`, mirroring
   `Domain/Nodes.cs` (1-based, `St7Native.*` calls only, no error checking).
3. Expose it as a `public XxxCollection Xxx => new(this);` property on
   `St7Model` (`Core/St7Model.cs`).
4. Surface any needed constants as an `enum` in `Core/Enums.cs` rather than
   leaking `St7.xx*` ints.
5. `dotnet build` — `Strand7Sharp.csproj` enables `Nullable`, `LangVersion=latest`,
   `GenerateDocumentationFile`, and suppresses `CS1591`.

## Runtime requirements

`St7API.dll` from a licensed Strand7 R3 install must be on the Windows DLL
search path; consumer `PlatformTarget` must match (x64 in R3). Only one
`Strand7Api` session is allowed per process (`Strand7Api.Initialize()` is a
singleton guarding `St7Init`/`St7Release`).

