using St7API;
namespace Strand7Sharp;
/// <summary>
/// Laminate stacks (composite layouts) and reinforcement layouts defined in
/// the model. Use <see cref="Laminates"/> for composite ply stacks and
/// <see cref="Reinforcements"/> for rebar layouts.
/// </summary>
public readonly struct LayoutCollection
{
    private readonly St7Model _m;
    internal LayoutCollection(St7Model m) => _m = m;
    /// <summary>Laminate (composite-ply-stack) layouts.</summary>
    public LaminateCollection Laminates => new(_m);
    /// <summary>Reinforcement (rebar) layouts.</summary>
    public ReinforcementCollection Reinforcements => new(_m);
}

/// <summary>Laminate / composite stack collection.</summary>
public readonly struct LaminateCollection
{
    private readonly St7Model _m;
    internal LaminateCollection(St7Model m) => _m = m;
    public (int NumStacks, int LastStack) Counts => St7Native.St7GetTotalLaminateStacks(_m.FileId);
    public int Count => Counts.NumStacks;
    public int GetIdByIndex(int index) => St7Native.St7GetLaminateStackNumByIndex(_m.FileId, index);
    public Laminate this[int laminateId] => new(_m, laminateId);
    public Laminate Add(int laminateId, string name)
    {
        St7Native.St7NewLaminate(_m.FileId, laminateId, name);
        return new Laminate(_m, laminateId);
    }
    /// <summary>Iterate every laminate (by index).</summary>
    public St7Enumerator<Laminate> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<Laminate>(Count, i => new Laminate(m, St7Native.St7GetLaminateStackNumByIndex(m.FileId, i)));
    }
}

/// <summary>A composite laminate (ordered stack of plies).</summary>
public readonly struct Laminate
{
    private readonly St7Model _m;
    public int Id { get; }
    internal Laminate(St7Model m, int id) { _m = m; Id = id; }

    public string Name
    {
        get => St7Native.St7GetLaminateName(_m.FileId, Id);
        set => St7Native.St7SetLaminateName(_m.FileId, Id, value);
    }
    public int NumPlies => St7Native.St7GetLaminateNumPlies(_m.FileId, Id);

    /// <summary>Set a ply at position <paramref name="pos"/> (1-based) using the given ply property and parameters.</summary>
    public void SetPly(int pos, int plyPropNum, double[] data)
        => St7Native.St7SetLaminatePly(_m.FileId, Id, pos, plyPropNum, data);

    /// <summary>Get the ply at <paramref name="pos"/>. Buffer length depends on the laminate type.</summary>
    public (int PlyPropNum, double[] Data) GetPly(int pos, int dataLen = 8)
    {
        var data = new double[dataLen];
        int plyProp = St7Native.St7GetLaminatePly(_m.FileId, Id, pos, data);
        return (plyProp, data);
    }
    public void DeletePly(int pos) => St7Native.St7DeleteLaminatePly(_m.FileId, Id, pos);
    public void Delete() => St7Native.St7DeleteLaminate(_m.FileId, Id);
}

/// <summary>Reinforcement layout collection.</summary>
public readonly struct ReinforcementCollection
{
    private readonly St7Model _m;
    internal ReinforcementCollection(St7Model m) => _m = m;
    public (int NumLayouts, int LastLayout) Counts => St7Native.St7GetTotalReinforcementLayouts(_m.FileId);
    public int Count => Counts.NumLayouts;
    public int GetIdByIndex(int index) => St7Native.St7GetReinforcementLayoutNumByIndex(_m.FileId, index);
    public ReinforcementLayout this[int layoutId] => new(_m, layoutId);
    public ReinforcementLayout Add(int layoutId, string name)
    {
        St7Native.St7NewReinforcementLayout(_m.FileId, layoutId, name);
        return new ReinforcementLayout(_m, layoutId);
    }
    /// <summary>Iterate every reinforcement layout (by index).</summary>
    public St7Enumerator<ReinforcementLayout> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<ReinforcementLayout>(Count, i => new ReinforcementLayout(m, St7Native.St7GetReinforcementLayoutNumByIndex(m.FileId, i)));
    }
}

/// <summary>A reinforcement (rebar) layout.</summary>
public readonly struct ReinforcementLayout
{
    private readonly St7Model _m;
    public int Id { get; }
    internal ReinforcementLayout(St7Model m, int id) { _m = m; Id = id; }
    /// <summary>Assign a reinforcement layout from the library.</summary>
    public void AssignLibrary(int libraryId, int itemId)
        => St7Native.St7AssignLibraryReinforcementLayout(_m.FileId, Id, libraryId, itemId);
    public void Delete() => St7Native.St7DeleteReinforcementLayout(_m.FileId, Id);
}

