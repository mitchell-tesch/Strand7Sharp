using System;
using St7API;
namespace Strand7Sharp;
/// <summary>
/// Disposable handle to an open Strand7 model file. Holds the file uID
/// used by every St7API call and exposes a domain-organised facet API:
/// <code>
/// using var api   = Strand7Api.Initialize();
/// using var model = api.OpenModel(@"C:\m\beam.st7", @"C:\tmp");
/// foreach (var n in Enumerable.Range(1, model.Nodes.Count))
///     Console.WriteLine(model.Nodes[n].XYZ);
/// model.LoadCases.Add("Dead");
/// model.Solver.Run(SolverType.LinearStatic);
/// </code>
/// Every facet (Nodes, Beams, LoadCases, ...) is a tiny value-type accessor.
/// They delegate to St7Native, which throws St7Exception on any non-zero error.
/// </summary>
public sealed class St7Model : IDisposable
{
    private bool _disposed;
    /// <summary>True once the underlying file has been closed.</summary>
    public bool IsDisposed => _disposed;
    /// <summary>The Strand7 file unit ID used by every St7API call.</summary>
    public int FileId { get; }
    /// <summary>Path of the model file on disk.</summary>
    public string FileName { get; }
    /// <summary>Fired when <see cref="Dispose"/> completes, carrying the FileId.</summary>
    internal event Action<int>? OnDisposed;
    private St7Model(int fileId, string fileName)
    {
        FileId = fileId;
        FileName = fileName;
    }
    internal static St7Model Open(int fileId, string fileName, string scratchPath, bool readOnly)
    {
        if (readOnly) St7Native.St7OpenFileReadOnly(fileId, fileName, scratchPath);
        else          St7Native.St7OpenFile(fileId, fileName, scratchPath);
        return new St7Model(fileId, fileName);
    }
    internal static St7Model AttachExisting(int fileId, string fileName) => new(fileId, fileName);
    /// <summary>Saves the model in place.</summary>
    public void Save() { ThrowIfDisposed(); St7Native.St7SaveFile(FileId); }
    /// <summary>Writes a copy of the model to a new path. Original file remains open.</summary>
    public void SaveCopyAs(string newFileName) { ThrowIfDisposed(); St7Native.St7SaveFileCopy(FileId, newFileName); }
    /// <summary>Returns the total number of entities of the given type (St7GetTotal).</summary>
    public int GetTotal(EntityType entity) { ThrowIfDisposed(); return St7Native.St7GetTotal(FileId, (int)entity); }
    /// <summary>Enclosed volume of the deformed plate-hull mesh at the given result case.</summary>
    public double PlateHullVolume(int resultCase = 0) { ThrowIfDisposed(); return St7Native.St7PlateHullVolume(FileId, resultCase); }
    /// <summary>Nodes in the model.</summary>
    public NodeCollection Nodes => new(this);
    /// <summary>Beam elements.</summary>
    public BeamCollection Beams => new(this);
    /// <summary>Plate elements.</summary>
    public PlateCollection Plates => new(this);
    /// <summary>Brick elements.</summary>
    public BrickCollection Bricks => new(this);
    /// <summary>Link elements (rigid, master/slave, MPC, ...).</summary>
    public LinkCollection Links => new(this);
    /// <summary>Geometry vertices (for geometry-based models).</summary>
    public VertexCollection Vertices => new(this);
    /// <summary>Geometry faces.</summary>
    public GeometryFaceCollection GeometryFaces => new(this);
    /// <summary>Geometry edges / co-edges.</summary>
    public GeometryEdgeCollection GeometryEdges => new(this);
    /// <summary>Load-path templates / load paths.</summary>
    public LoadPathCollection LoadPaths => new(this);
    /// <summary>Load case definitions.</summary>
    public LoadCaseCollection LoadCases => new(this);
    /// <summary>Freedom case definitions.</summary>
    public FreedomCaseCollection FreedomCases => new(this);
    /// <summary>Beam property definitions.</summary>
    public BeamPropertyCollection BeamProperties => new(this);
    /// <summary>Plate property definitions.</summary>
    public PlatePropertyCollection PlateProperties => new(this);
    /// <summary>Brick property definitions.</summary>
    public BrickPropertyCollection BrickProperties => new(this);
    /// <summary>Display / visibility groups.</summary>
    public GroupCollection Groups => new(this);
    /// <summary>User-defined coordinate systems.</summary>
    public UcsCollection UCS => new(this);
    /// <summary>Entity sets (saved selections).</summary>
    public EntitySetCollection EntitySets => new(this);
    /// <summary>Construction stages.</summary>
    public StageCollection Stages => new(this);
    /// <summary>Tables (factor-vs-X / temperature / etc.).</summary>
    public TableCollection Tables => new(this);
    /// <summary>Reinforcement / composite layouts.</summary>
    public LayoutCollection Layouts => new(this);
    /// <summary>Cavity-fluid layouts (sealed-gas / constant-bulk cavities).</summary>
    public CavityFluidCollection CavityFluids => new(this);
    /// <summary>Solver controls.</summary>
    public SolverApi Solver => new(this);
    /// <summary>Selection state.</summary>
    public SelectionApi Selection => new(this);
    /// <summary>Mesh / cleaning / geometry tools.</summary>
    public ToolsApi Tools => new(this);
    /// <summary>General model metadata: titles, descriptions, settings.</summary>
    public GeneralModelApi General => new(this);
    /// <summary>On-screen Strand7 model-window controls (create/embed, view cases, image export, animations).</summary>
    public WindowApi Window => new(this);
    /// <summary>Get or set the model's unit system in one call.</summary>
    public Strand7Units Units
    {
        get { ThrowIfDisposed(); var u = new int[St7.kLastUnit]; St7Native.St7GetUnits(FileId, u); return Strand7Units.FromArray(u); }
        set { ThrowIfDisposed(); St7Native.St7SetUnits(FileId, value.ToArray()); }
    }
    /// <summary>Opens the named result file against this model.</summary>
    public St7Results OpenResults(string resultFileName, string? spectralFileName = null, int combinationCode = 0)
    {
        ThrowIfDisposed();
        return St7Results.Open(this, resultFileName, spectralFileName, combinationCode);
    }
    internal void ThrowIfDisposed()
    {
        if (_disposed) throw new ObjectDisposedException(nameof(St7Model));
    }
    public void Dispose()
    {
        if (_disposed) return;
        _disposed = true;
        try { St7.St7CloseFile(FileId); } catch { /* ignore */ }
        OnDisposed?.Invoke(FileId);
    }
}
