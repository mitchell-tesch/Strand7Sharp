# Staged-Layers Follow-ups — Design Plan

This document is a design proposal for a batch of **seven additive Layer-3 improvements** to Strand7Sharp, motivated by rough edges surfaced while porting the internal `St7StagedLayers` tool. All changes are backwards-compatible.

> **Status:** awaiting sign-off on the API surface. Nothing is implemented yet.
>
> Delete this file after the batch is merged if it isn't wanted as a durable design record.

---

## Contents

1. [Layer-3 DXF export helper](#1-layer-3-dxf-export-helper)
2. [`Group` on `LoadPathTemplate`](#2-group-on-loadpathtemplate)
3. [Typed `St7ErrorCode` enum](#3-typed-st7errorcode-enum)
4. [Bulk stage/group snapshot](#4-bulk-stagegroup-snapshot)
5. [`TryDelete` on `GroupCollection`](#5-trydelete-on-groupcollection)
6. [Auto-create scratch directory in `OpenModel`](#6-auto-create-scratch-directory-in-openmodel)
7. [`St7Model.RootGroupId`](#7-st7modelrootgroupid)
8. [Cross-cutting: CHANGELOG entry, version bump](#cross-cutting)

Each section is written so it can stand alone as one commit.

---

## 1. Layer-3 DXF export helper

### Rationale

`St7ExportDXF` today is only reachable via `St7Native` with a raw `int[8]`
indexed by `ipDXFExport*` constants. Every consumer re-derives the option
layout. The internal `St7StagedLayers` port already had to build a
`DxfExportOptions` shim + typed enums to keep the call-site clean.

### API surface

```csharp
// Domain/Export.cs — new file, or extend Tools.cs

public enum BeamExport         { Line, Section, Solid }
public enum PlateExport        { Surface, Solid }
public enum ProgressMode       { Quiet = St7.ieQuietRun, Progress = St7.ieProgressRun }

public readonly record struct DxfExportOptions
{
    public BeamExport BeamExport                    { get; init; } = BeamExport.Solid;
    public PlateExport PlateExport                  { get; init; } = PlateExport.Solid;
    public bool IncludeBeamOffsets                  { get; init; } = true;
    public bool IncludePlateOffsets                 { get; init; } = true;
    public bool GroupsAsLayers                      { get; init; } = true;
    public bool PropertyColoursAsEntityColours      { get; init; } = true;
    public bool PlatesBricksAs3DFaces               { get; init; } = true;
    public bool ExportInternalBrickFaces            { get; init; } = false;

    /// <summary>Serialise to the 8-element option array St7ExportDXF expects.</summary>
    public int[] ToNativeOptions();

    public static DxfExportOptions Default = new();
}
```

Exposed on `St7Model`:

```csharp
public partial class St7Model
{
    public void ExportDXF(string fileName,
                          DxfExportOptions? options = null,
                          ProgressMode progressMode = ProgressMode.Quiet);
}
```

### Alternatives considered

- Adding a method on `ToolsApi` (`model.Tools.ExportDXF(...)`) — reasonable but export isn't really a "tool" in the mesh-editing sense; a top-level `St7Model.ExportDXF` is more discoverable.
- A builder pattern (`new DxfExport(model).WithSolids(false).Run()`) — over-engineered for an 8-flag call.

### Files touched

- `Strand7Sharp/Domain/Export.cs` (new)
- `Strand7Sharp/Core/St7Model.cs` (add `ExportDXF` method)

### Open questions

- **Q1.1:** Default progress mode — `Quiet` (safer for headless / server contexts) or `Progress` (matches the Python-era behaviour)? *Answer: Quiet.*
- **Q1.2:** Should `ExportDXF` also live on `ToolsApi` as an alias for discoverability? *Answer: No, keep it on `St7Model` only.*
- **Q1.3:** Want a matching `ImportDXF` in the same commit or defer? *Answer defer — that surface has 12+ options and deserves its own pass.*

---

## 2. `Group` on `LoadPathTemplate`

### Rationale

Beam / Plate / Brick / Link / GeometryFace all expose a `.Group` property (int get/set) — `LoadPathTemplate` doesn't, forcing a fall-through to `St7Native.St7GetEntityGroup(..., (int)EntityType.LoadPath, id)`.

### API surface

```csharp
// Extend Domain/LoadPaths.cs — the existing LoadPathTemplate struct

public readonly struct LoadPathTemplate
{
    // ... existing members ...

    /// <summary>The group ID this load path is assigned to.</summary>
    public int Group
    {
        get => St7Native.St7GetEntityGroup(_m.FileId, St7.tyLOADPATH, Id);
        set => St7Native.St7SetEntityGroup(_m.FileId, St7.tyLOADPATH, Id, value);
    }
}
```

### Files touched

- `Strand7Sharp/Domain/LoadPaths.cs`

### Open questions

- **Q2.1:** Is `Id` (the load-path *template* ID) the correct entity number to pass to `St7*EntityGroup(tyLOADPATH, ...)`? The Python code and the internal port both assume so; the R3 API docs say `tyLOADPATH` is valid but don't explicitly disambiguate template vs path. If it turns out to be the *path* id, we'd want the property on a `LoadPath` struct rather than the template. *Answer: Load path is a load path template*

---

## 3. Typed `St7ErrorCode` enum

### Rationale

`St7Exception.ErrorCode` today is `int`. Consumer code writing `catch (St7Exception ex) when (ex.ErrorCode == 26)` is opaque. A typed enum (partial coverage acceptable) makes intent readable and IDE-discoverable.

### API surface

```csharp
// Core/St7ErrorCode.cs — new file

/// <summary>
/// Symbolic names for the most commonly-caught Strand7 error codes. Values match
/// the raw <c>St7API.St7.ERR7_*</c> constants. Not exhaustive — cast an
/// int to <see cref="St7ErrorCode"/> to inspect codes not enumerated here.
/// </summary>
public enum St7ErrorCode
{
    None = 0,
    // ... populate from St7API.St7.ERR7_* constants, e.g.:
    CannotDeleteGroup = 26,  // TBD: verify the exact ERR7 constant that maps here.
    InvalidDXFBeamOption = St7.ERR7_InvalidDXFBeamOption,
    InvalidDXFPlateOption = St7.ERR7_InvalidDXFPlateOption,
    // ...
}
```

Extend `St7Exception`:

```csharp
public sealed class St7Exception : Exception
{
    // ... existing ...

    /// <summary>Typed view of the error code where a name is known, else <c>(St7ErrorCode)ErrorCode</c>.</summary>
    public St7ErrorCode Code => (St7ErrorCode)ErrorCode;
}
```

### Files touched

- `Strand7Sharp/Core/St7ErrorCode.cs` (new)
- `Strand7Sharp/Core/St7Exception.cs` (add `Code` property)

### Open questions

- **Q3.1:** How many codes to enumerate? Options:
  - (a) Only the ones consumers commonly `catch` on (~15 codes).
  - (b) All ~250 `ERR7_*` constants from `St7API.cs`, auto-generated.
  - *Answer (b) do all.*
- **Q3.2:** Which specific ERR7 constant does the "cannot delete this group" case (error 26) actually map to? Need to grep `Interop/St7API.cs` for `= 26`.

---

## 4. Bulk stage/group snapshot

### Rationale

Determining a group's first-active / last-active stage today is O(nGroups × nStages) `IsGroupEnabled` calls. For a large staged model (say 200 groups × 30 stages) that's 6000 native calls per pass. A bulk API lets the caller pull the whole matrix once.

### API surface

Two flavours; pick one or ship both.

**Option A — matrix on `StageCollection`:**

```csharp
public readonly struct StageCollection
{
    // ... existing ...

    /// <summary>
    /// (groupId, stageNumber) → true if enabled. Materialised once from a full
    /// walk over Stages × Groups; useful when you need the whole matrix.
    /// </summary>
    public IReadOnlyDictionary<(int GroupId, int Stage), bool> BuildEnabledMatrix();
}
```

**Option B — per-group lifecycle helper on `GroupCollection`:**

```csharp
public readonly struct GroupCollection
{
    // ... existing ...

    /// <summary>
    /// For each group, return the first stage it becomes enabled and the first
    /// stage after that at which it becomes disabled again (null when it never
    /// deactivates). Groups never enabled in any stage yield <c>(null, null)</c>.
    /// </summary>
    public IReadOnlyDictionary<int, (int? Start, int? End)> GetStageLifecycles();
}
```

*I favour B — it matches the exact analysis the staged-layers port does, hides the matrix, and covers the 80% use-case in one call. A can be added later if someone needs the raw matrix.*

### Files touched

- `Strand7Sharp/Domain/Groups.cs` (or `Stages.cs`)

### Open questions

- **Q4.1:** A vs B (or both). *Answer: Both*
- **Q4.2:** Return type — `IReadOnlyDictionary<int, (int?, int?)>` vs a named record `StageLifecycle(int? Start, int? End)`. *Recommend the named record for clarity at call sites.*

---

## 5. `TryDelete` on `GroupCollection`

### Rationale

Currently `Delete(id)` throws on any non-zero result, including error 26 ("can't delete this group — has children / root"). A `TryDelete` variant makes bulk cleanup patterns clean.

### API surface

```csharp
public readonly struct GroupCollection
{
    // ... existing ...

    /// <summary>
    /// Attempts to delete the group. Returns <c>true</c> on success, <c>false</c>
    /// if St7 refused (e.g. the group is the root or has children). Any other
    /// error still propagates as an <see cref="St7Exception"/>.
    /// </summary>
    public bool TryDelete(int groupId);
}
```

Implementation sketch:

```csharp
public bool TryDelete(int groupId)
{
    try { St7Native.St7DeleteGroup(_m.FileId, groupId); return true; }
    catch (St7Exception ex) when (ex.Code is St7ErrorCode.CannotDeleteGroup)
    { return false; }
}
```

### Files touched

- `Strand7Sharp/Domain/Groups.cs`

### Open questions

- **Q5.1:** Should we also expose the raw error for callers who want to log it? A `TryDelete(int, out St7ErrorCode)` overload? *Answer: yes include.*

---

## 6. Auto-create scratch directory in `OpenModel`

### Rationale

`St7OpenFile` fails with "Bad scratch path" if the directory doesn't exist. Every consumer ends up writing the same `Directory.CreateDirectory(scratch)` before calling `OpenModel`. Auto-creating it is safer and removes boilerplate. Scratch should be created in system temp if not specified.

### API surface

Behavioural change to `Strand7Api.OpenModel` / `OpenModelReadOnly` / `NewModel`: if `scratchPath` doesn't exist, create it. No signature change.

```csharp
public St7Model OpenModel(string fileName, string scratchPath, int fileId = 0)
{
    ThrowIfDisposed();
    EnsureScratchDirectory(scratchPath);
    int id = ResolveFileId(fileId);
    var m = St7Model.Open(id, fileName, scratchPath, readOnly: false);
    Register(m);
    return m;
}

private static void EnsureScratchDirectory(string scratchPath)
{
    if (!Directory.Exists(scratchPath))
        Directory.CreateDirectory(scratchPath);
}
```

### Files touched

- `Strand7Sharp/Core/Strand7Api.cs`

### Open questions

- **Q6.1:** Should we throw a wrapping exception on `UnauthorizedAccessException` from `Directory.CreateDirectory`? Or let it propagate as-is? *Recommend propagate as-is — the .NET exception is descriptive.*
- **Q6.2:** Any concern about a caller who explicitly wants the pre-check to fail (defensive path)? *Doubtful, but noted.*

---

## 7. `St7Model.RootGroupId`

### Rationale

`St7GetDefaultGroupID` is the API's authoritative way to get the root group id — hard-coding `1` works today but tightly couples callers to an implementation detail. A tiny Layer-3 property removes the coupling.

### API surface

```csharp
public sealed partial class St7Model
{
    /// <summary>The root (default) group id, as reported by St7GetDefaultGroupID.</summary>
    public int RootGroupId => St7Native.St7GetDefaultGroupID(FileId);
}
```

Or, arguably better, on `GroupCollection`:

```csharp
public readonly struct GroupCollection
{
    // ...

    /// <summary>The root group id.</summary>
    public int RootId => St7Native.St7GetDefaultGroupID(_m.FileId);
}
```

### Files touched

- `Strand7Sharp/Core/St7Model.cs` or `Strand7Sharp/Domain/Groups.cs`

### Open questions

- **Q7.1:** `St7Model.RootGroupId` vs `model.Groups.RootId`. *Weakly prefer `model.Groups.RootId` since it groups (heh) all group-related concerns together.*
- **Q7.2:** Cache the value? Root ID doesn't change over a model's lifetime. *Micro-optimisation, skip unless profile shows it matters.*

---

## Cross-cutting

- **CHANGELOG.md** — one bullet per commit under `[Unreleased] → Added` (or `Changed` for the auto-scratch behaviour tweak in #6).
- **Version bump** — `[Unreleased]` → `[0.2.0]` at merge time. All changes are additive, no breaking → minor bump.
- **Docs** — none of these need updates in `docs/api/*.md` (auto-generated). The `README.md` "Coverage of Layer 3" list could optionally get one bullet mentioning DXF export.
- **Tests** — Strand7Sharp doesn't currently have a test project. Not adding one as part of this batch; noting as a future item.

### Commit plan (one per item)

| # | Commit subject |
|---|---|
| 1 | `feat(export): typed DxfExportOptions + St7Model.ExportDXF` |
| 2 | `feat(load-paths): expose Group on LoadPathTemplate` |
| 3 | `feat(errors): typed St7ErrorCode enum + St7Exception.Code` |
| 4 | `feat(groups): GetStageLifecycles bulk snapshot` |
| 5 | `feat(groups): TryDelete for graceful skipping of undeletable groups` |
| 6 | `feat(session): auto-create scratch directory in OpenModel` |
| 7 | `feat(groups): expose root group id via GroupCollection.RootId` |
| 8 | `docs: CHANGELOG for v0.2.0` |

---

## Sign-off checklist

Before implementation begins, please indicate agreement (or edits) on:

- [ ] **API shapes** as sketched above.
- [ ] **Q1.1** — default `ProgressMode` for `ExportDXF`.
- [ ] **Q1.2** — expose `ExportDXF` on `ToolsApi` too?
- [ ] **Q2.1** — confirm `tyLOADPATH` addresses the template id (not the load path id).
- [ ] **Q3.1** — enumerate ~15 common error codes now, defer the rest.
- [ ] **Q3.2** — I'll audit `Interop/St7API.cs` for the exact `ERR7_*` matching code 26 during implementation.
- [ ] **Q4.1/4.2** — go with Option B (`GetStageLifecycles`) returning a named record.
- [ ] **Q5.1** — keep `TryDelete` bool-only for now.
- [ ] **Q7.1** — place `RootId` on `GroupCollection` rather than `St7Model`.
