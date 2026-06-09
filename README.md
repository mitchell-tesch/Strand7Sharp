<img src="https://raw.githubusercontent.com/mitchell-tesch/Strand7Sharp/main/assets/icon.png" alt="Strand7Sharp icon" width="128" align="right" />

# Strand7Sharp

[![build](https://github.com/mitchell-tesch/Strand7Sharp/actions/workflows/build.yml/badge.svg)](https://github.com/mitchell-tesch/Strand7Sharp/actions/workflows/build.yml)
[![NuGet](https://img.shields.io/nuget/v/Strand7Sharp.svg)](https://www.nuget.org/packages/Strand7Sharp/)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)

An idiomatic C# / .NET wrapper around the **Strand7 R3 API** (`St7API.dll`).
It ships **three concentric layers** so you can pick whichever fits your task:

| Layer | Namespace | What it gives you |
| --- | --- | --- |
| **1. Raw P/Invoke** | `St7API.St7` | Verbatim copy of Strand7's official `St7API.cs`. Every function returns an `int` error code and uses `ref`, `StringBuilder`, etc. Use this when you need to do something the higher layers don't expose. |
| **2. Auto-generated managed wrappers** | `Strand7Sharp.St7Native` | **All 1918** API functions, regenerated from `St7API.cs` by `tools/Generate-Wrapper.ps1`. Every method throws `St7Exception` on a non-zero error, promotes `ref` parameters to `ValueTuple` returns, and turns the `(StringBuilder, int MaxStringLen)` idiom into a `string` return. |
| **3. Hand-curated OO surface** | `Strand7Sharp.*` (`St7Model`, `Node`, `Beam`, …) | A small, discoverable, intuitive object model built on layer 2. |

## Quick start

```csharp
using Strand7Sharp;

using var api   = Strand7Api.Initialize();                       // St7Init / St7Release
using var model = api.OpenModel(@"C:\models\beam.st7", @"C:\temp");

Console.WriteLine($"Strand7 {api.Version} ({api.BuildString})");
Console.WriteLine($"Nodes: {model.Nodes.Count}, Beams: {model.Beams.Count}");
Console.WriteLine($"Units: {model.Units}");
```

## The Layer-3 OO surface

Everything hangs off **`Strand7Api`** (the singleton, app-level session) and
**`St7Model`** (one per open `.st7` file — the session supports many at once).

```text
Strand7Api  ── Version, BuildString, MaxModelFileId, LicenceOptions,
            │  ListSeparatorCode, DecimalSeparatorCode, IconSize
            ├── Settings           (ApplicationSettings: global ints/bools/strings, UseSolverDll)
            └── OpenModel / OpenModelReadOnly / NewModel  → St7Model

St7Model    ── FileId, FileName, Units, Save, SaveCopyAs, GetTotal, OpenResults
            ├── Entities:    Nodes, Beams, Plates, Bricks, Links,
            │                Vertices, GeometryFaces, GeometryEdges, LoadPaths
            ├── Cases:       LoadCases, FreedomCases, Stages, NLAIncrements
            ├── Coords/Sets: UCS, Groups, EntitySets
            ├── Properties:  BeamProperties, PlateProperties, BrickProperties
            ├── Tables:      Tables, Layouts (.Laminates / .Reinforcements),
            │                CavityFluids
            ├── Run:         Solver  →  OpenResults(...)  → St7Results
            ├── UI / tools:  Selection, Tools, Window
            └── Metadata:    General (titles, comments, ResultCombinations)
```

### Coverage of Layer 3

Layer 3 is **deliberately not a 1:1 wrapper** over all 1918 St7 functions —
that's what Layer 2 (`St7Native`) is for. Instead it covers the **common 80%**
of model-building, solving, and result-reading workflows behind a small,
discoverable, value-type-only surface. Concretely:

- **Session lifecycle** — `Strand7Api.Initialize()` / `Dispose` (singleton
  `St7Init`/`St7Release`), multi-model sessions via `OpenModel` /
  `OpenModelReadOnly` / `NewModel` with auto-allocated `FileId`s, plus
  `api.Settings` for the app-level integer/bool/string slots and
  `UseSolverDll` toggle.
- **All mesh entities** — `Nodes`, `Beams`, `Plates`, `Bricks`, `Links`
  (rigid, master/slave, MPC, attachment, point-contact, …), with full CRUD
  (`Add`, indexer, `Count`, `foreach`) and the day-to-day attribute set
  (XYZ / connection / property / group / id / restraints / forces / moments
  / springs / masses / temperature / pressures / edge & end releases /
  offsets / orientation).
- **Geometry (pre-mesh) entities** — `Vertices`, `GeometryFaces`,
  `GeometryEdges`, `LoadPaths`, including mesh sizing, property assignment,
  thickness, normal alignment, and the load-path template helpers.
- **Cases & staging** — `LoadCases`, `FreedomCases`, `Stages` (with
  `EnableGroup`, `FluidLevel`, `SolverActiveStage`, …), and
  `NLAIncrements` for non-linear step tables.
- **Coordinate systems & grouping** — `UCS`, `Groups` (hierarchical), and
  `EntitySets` (with `AddSelectedToEntitySet`-style helpers).
- **Properties, tables, layouts** — typed `BeamProperties` /
  `PlateProperties` / `BrickProperties` with material assignment and
  library look-ups (`AssignLibrarySection`, `AssignLibraryMaterial`,
  `AssignLibraryComposite`, `AssignLibraryReinforcementLayout`,
  `AssignLibraryCreepDefinition`), strongly-typed `Tables`
  (`TableType` enum keyed `Add`/`Enumerate`/`Data`), composite/
  reinforcement `Layouts.Laminates` and `Layouts.Reinforcements`, and
  `CavityFluids` for sealed-gas / constant-bulk cavities.
- **Solver** — `Solver` (linear/nonlinear/dynamic/harmonic/spectral/
  transient/buckling/QSA/SRA/HRA) with in-proc `Run(...)` **and**
  out-of-proc `RunProcess(...)` + `IsProcessRunning` polling, plus the
  common scalar controls (`NonlinearGeometry`, `NumCpu`, `FreedomCase`,
  `SetDefault*`, …).
- **Results** — `model.OpenResults(...)` → `St7Results`: case enumeration
  (`PrimaryCount`, `GetCaseName`/`Time`/`Factor`/`KineticEnergy`), node /
  beam / plate / brick result extraction, and result-combination setup.
- **Tooling, UI & metadata** — `Selection` (programmatic select-by-property
  / select-all / counts), `Tools` (clean-mesh, delete-unused-nodes,
  subdivide, reorder, geometry cleaning), `Window` (embed/create the
  Strand7 model window, switch view cases, export images, build
  animations), and `General` for titles / project / author / comments and
  `ResultCombinations`.

What Layer 3 **doesn't** include is reached by simply calling
`Strand7Sharp.St7Native.St7XxxYyy(...)` — the same exception-based wrappers
the OO surface itself is built on. If a Layer-3 facet is missing a method
you need, prefer to add it to the relevant `Domain/Xxx.cs` rather than
working around it at the call site (see *Adding a new Layer-3 facet* in
`AGENTS.md`).

### Multiple models in one session

```csharp
using var api  = Strand7Api.Initialize();
using var m1   = api.OpenModel(@"C:\m\a.st7", @"C:\tmp");  // auto-allocated FileId
using var m2   = api.OpenModel(@"C:\m\b.st7", @"C:\tmp");  // next free FileId

foreach (var m in api.OpenModels)
    Console.WriteLine($"#{m.FileId}: {m.FileName}");
```

### Entities — Get / Set common attributes

Every entity collection is a 1-based indexable, iterable, allocation-free
value-type accessor.

```csharp
// Nodes -----------------------------------------------------------------
int n = model.Nodes.Add(new Vector3(1.0, 0, 0));
model.Nodes[n].XYZ   = new Vector3(1.5, 0, 0);
model.Nodes[n].Group = 1;
model.Nodes[n].Id    = 1001;

foreach (var node in model.Nodes)                            // iterable
    Console.WriteLine($"#{node.Number}  {node.XYZ}");

// Forces, restraints, springs, masses, temperature ----------------------
int dead = model.LoadCases.Add("Dead");
int fc   = 1;

model.Nodes[1].Fix(fc);                                       // pin all 6 DOFs
model.Nodes[2].SetRestraint(fc, ucsId: 1,
    status: DofStatus.PinnedXYZ, values: DofValues.Zero);
model.Nodes[3].SetForce(dead, new Vector3(0, 0, -1000));
model.Nodes[3].SetTranslationalSpringStiffness(dead, ucsId: 1, new Vector3(0, 0, 1e6));
model.Nodes[4].SetTemperature(dead, 75.0);
model.Nodes[4].SetTemperatureType(dead, NodeTemperatureType.Fixed);

// Beams -----------------------------------------------------------------
int b = model.Beams.Add(node1: 1, node2: 2, property: 1);
var (a, c) = model.Beams[b].Connection;
model.Beams[b].Offset = new double[] { 0, 0, 0,  0, 0, 0 };
model.Beams[b].SetTranslationRelease(beamEnd: 1, status: new[]{0,1,1}, stiffness: new double[3]);
model.Beams[b].SetTemperatureGradient(dead, dT_dY: 0, dT_dZ: 10);

// Plates / Bricks -------------------------------------------------------
int p = model.Plates.Add(property: 1, 1, 2, 3, 4);
model.Plates[p].Thickness = (Top: 0.010, Bottom: 0.010);
model.Plates[p].SetNormalPressure(dead, pressureTop: -2500, pressureBottom: 0);
model.Plates[p].SetEdgeRelease(edge: 1, status: new[]{0,0,1,0,0,0});

int br = model.Bricks.Add(property: 1, 1,2,3,4,5,6,7,8);
model.Bricks[br].SetGlobalPressure(dead, faceNum: 1, project: false,
                                   new Vector3(0, 0, -100_000));

// Links -----------------------------------------------------------------
int link = model.Links.AddRigid(ucsId: 1, plane: 0, 1, 2, 3);
Console.WriteLine(model.Links[link].Type);                   // LinkType.Rigid

// Geometry vertices / faces / edges ------------------------------------
foreach (var v in model.Vertices)
    Console.WriteLine($"vertex #{v.Number} at {v.XYZ}, mesh size={v.MeshSize}");

foreach (var face in model.GeometryFaces)
{
    face.Property  = 1;
    face.Thickness = (0.012, 0.012);
    face.SetNormalPressure(dead, -1000);
}
```

### Cases, freedom, UCS, groups, sets, stages

```csharp
int g  = model.Groups.AddChild(parentId: 0, "Slab");
int es = model.EntitySets.Add("WallNodes");
int s  = model.Stages.Add("Excavation", morph: true, moveFixedNodes: true);

model.Stages[s].EnableGroup(g);
model.Stages[s].FluidLevel = -2.5;
model.Stages.SolverActiveStage = s;

foreach (var stage in model.Stages)
    Console.WriteLine($"{stage.Number}: {stage.Name}");

foreach (var (name, id) in model.Groups)
    Console.WriteLine($"group {id}: {name}, visible={model.Groups.GetVisible(id)}");
```

### Properties, tables, layouts

```csharp
// Beam property — pick a type, set material, optionally pull from the library
int bp = model.BeamProperties.Add(BeamType.Beam, "Steel CHS");
model.BeamProperties[bp].Material = new double[]
{
    /*E*/ 2.0e11, /*nu*/ 0.3, /*density*/ 7850, /*alpha*/ 1.2e-5
};
model.BeamProperties[bp].AssignLibrarySection(libraryId: 1, itemId: 42, integers: new int[8]);

// Plate property
int pp = model.PlateProperties.Add(PlateType.PlateShell, MaterialType.Isotropic, "Concrete 32MPa");
model.PlateProperties[pp].AssignLibraryMaterial(libraryId: 0, itemId: 7);

// Tables (factor-vs-X, time, temperature, …) — strongly-typed key
var tbl = model.Tables.Add(TableType.VsTime, tableId: 1, "Ground motion",
    numEntries: 3, data: new[] { 0.0,0.0,  0.5,1.0,  1.0,0.0 });
tbl.Data = new[] { 0.0,0.0,  0.4,0.8,  1.0,0.0 };            // edit in place

foreach (var t in model.Tables.Enumerate(TableType.VsTime))
    Console.WriteLine($"{t.Id}: {t.Name} ({t.RowCount} rows)");

// Composite / reinforcement layouts
var lam = model.Layouts.Laminates.Add(laminateId: 1, "8-ply CFRP");
lam.SetPly(pos: 1, plyPropNum: 1, data: new double[] { /*thickness*/ 0.125, /*angle*/ 0 });
```

### Solver / Results / Tools

```csharp
model.Solver.NonlinearGeometry = true;
model.Solver.NumCpu            = 8;
model.Solver.FreedomCase       = 1;
model.Solver.Run(SolverType.LinearStatic, resultFileName: @"C:\models\beam.lsa");

// Or async, out-of-proc:
int pid = model.Solver.RunProcess(SolverType.NonlinearStatic);
while (SolverApi.IsProcessRunning(pid)) Thread.Sleep(500);

using var r = model.OpenResults(@"C:\models\beam.lsa");
for (int i = 1; i <= r.PrimaryCount; i++)
    Console.WriteLine($"{r.GetCaseName(i)}  t={r.GetCaseTime(i)}  λ={r.GetCaseFactor(i)}  KE={r.GetCaseKineticEnergy(i)}");

double[] disp = r.GetNodeResult(resultType: 1 /*rtNodeDisp*/, nodeNum: 5, caseNum: 1);

// Tools (mesh / geometry / clean / subdivide / re-order) ---------------
model.Tools.CleanMesh();
model.Tools.DeleteUnusedNodes();
model.Tools.Subdivide(divsA: 2, divsB: 2, divsC: 1);
model.Tools.ReorderNodesAMD();
```

### Selection, general model, application settings

```csharp
model.Selection.SelectAll(EntityType.Plate);
model.Selection.SelectByProperty(EntityType.Beam, propertyNum: 3);
int sel = model.Selection.Count(EntityType.Beam);

model.General.Title    = "Pedestrian bridge — ULS check";
model.General.Project  = "Job 2026-014";
model.General.Author   = "ACME Engineers";
model.General.SetComment(0, "Generated by Strand7Sharp on " + DateTime.Now);

model.General.ResultCombinations.AddLSACombination("1.2DL + 1.5LL");

// Strand7Api.Settings — app-level slots St7 hosts use to expose state
api.Settings.UseSolverDll = true;
int    ix  = api.Settings.GetInteger(0);
bool   ix2 = api.Settings.GetBool(0);
string sx  = api.Settings.GetString(0);
```

### Fall through to the lower layers

When the OO layer doesn't expose what you need, drop down to `St7Native`:

```csharp
// 1918 wrappers — every St7API function, exception-based:
var build             = St7Native.St7BuildString();
var (maj, min, point) = St7Native.St7Version();
St7Native.St7NewBeamProperty(model.FileId, 5, St7API.St7.btBeam, "Custom");
```

And if you need raw `ref`/`out` semantics, fall back to the original P/Invoke:

```csharp
St7Check.Check(St7API.St7.St7SetNodeRestraint6(uID, n, fc, ucs, status, values));
```

### Errors

Every Layer-2 / Layer-3 call funnels through `St7Check.Check(...)` and throws
`St7Exception` (message decoded via `St7GetAPIErrorString`) on any non-zero
error code — no manual return-code plumbing in user code.

```csharp
try
{
    model.Solver.Run(SolverType.LinearStatic);
}
catch (St7Exception ex)
{
    Console.Error.WriteLine($"{ex.FunctionName}: {ex.Message} (code {ex.ErrorCode})");
}
```

## Project layout

```
Strand7Sharp/
├── Strand7Sharp/
│   ├── Interop/St7API.cs            # Original Strand7 P/Invoke (Layer 1) - regenerated XML docs above each [DllImport]
│   ├── Generated/St7Native.g.cs     # Auto-generated managed wrappers (Layer 2) - 1918 methods
│   ├── Core/                        # Strand7Api, St7Model, St7Exception, St7Check, St7Enumerator, enums
│   └── Domain/                      # Hand-curated facets (Layer 3)
│       ├── Application.cs   GeneralModel.cs   Comments.cs    Window.cs
│       ├── Tools.cs         Selection.cs
│       ├── Nodes.cs         Beams.cs          Plates.cs      Bricks.cs      Links.cs
│       ├── Vertices.cs      GeometryFaces.cs  GeometryEdges.cs  LoadPaths.cs
│       ├── LoadCases.cs     FreedomCases.cs   Ucs.cs         Groups.cs
│       ├── EntitySets.cs    Stages.cs         NLAIncrements.cs
│       ├── Properties.cs    Tables.cs         Layouts.cs     CavityFluids.cs
│       └── Solver.cs        Results.cs
├── docs/
│   ├── AGENTS.md                    # How to feed the manual to an AI agent
│   └── api/St7*.md                  # 1916 per-function pages (regenerated from the PDF)
└── tools/
    ├── Convert-ApiManual.ps1        # PDF -> docs/api/St7*.md
    ├── Inject-XmlDocs.ps1           # docs/api/*.md -> <summary> on every [DllImport]
    └── Generate-Wrapper.ps1         # St7API.cs -> Generated/St7Native.g.cs
```

## Prerequisites

- **Windows** (the assembly is `net8.0-windows` / `net48`).
- A licensed **Strand7 R3** install with `St7API.dll` on the Windows DLL search path.
- Match your consumer project's `PlatformTarget` to your installed `St7API.dll` (x64 in R3).

## Regenerating

```powershell
# After installing markitdown into .venv:
pwsh tools/Convert-ApiManual.ps1     # PDF -> docs/api/*.md
pwsh tools/Inject-XmlDocs.ps1        # markdown -> XML doc comments
pwsh tools/Generate-Wrapper.ps1      # St7API.cs -> St7Native.g.cs
dotnet build -c Release
dotnet pack  -c Release
```

All three generators are idempotent.

