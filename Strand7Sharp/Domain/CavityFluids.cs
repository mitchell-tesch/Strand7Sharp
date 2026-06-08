using St7API;
namespace Strand7Sharp;

/// <summary>
/// Cavity-fluid layouts (sealed-gas / constant-bulk cavities used by plate
/// and brick face elements). 1-based by layout ID; layouts are attached to
/// element faces via <see cref="Plate.SetCavityFluid"/> /
/// <see cref="Brick.SetCavityFluid"/>.
/// </summary>
public readonly struct CavityFluidCollection
{
    private readonly St7Model _m;
    internal CavityFluidCollection(St7Model m) => _m = m;

    public (int NumLayouts, int LastLayout) Counts => St7Native.St7GetTotalCavityFluidLayouts(_m.FileId);
    public int Count => Counts.NumLayouts;
    public int GetIdByIndex(int index) => St7Native.St7GetCavityFluidLayoutNumByIndex(_m.FileId, index);
    public CavityFluid this[int cavityId] => new(_m, cavityId);

    public CavityFluid Add(int cavityId, string name)
    {
        St7Native.St7NewCavityFluidLayout(_m.FileId, cavityId, name);
        return new CavityFluid(_m, cavityId);
    }
    public St7Enumerator<CavityFluid> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<CavityFluid>(Count, i => new CavityFluid(m, St7Native.St7GetCavityFluidLayoutNumByIndex(m.FileId, i)));
    }
}

/// <summary>A single cavity-fluid layout entry.</summary>
public readonly struct CavityFluid
{
    private readonly St7Model _m;
    public int Id { get; }
    internal CavityFluid(St7Model m, int id) { _m = m; Id = id; }
    public string Name
    {
        get => St7Native.St7GetCavityFluidName(_m.FileId, Id);
        set => St7Native.St7SetCavityFluidName(_m.FileId, Id, value);
    }
    public int Type => St7Native.St7GetCavityFluidType(_m.FileId, Id);

    public (int[] Integers, double[] Doubles) GetConstBulk(int intLen = 4, int doubleLen = 8)
    {
        var ints = new int[intLen]; var dbls = new double[doubleLen];
        St7Native.St7GetCavityFluidConstBulk(_m.FileId, Id, ints, dbls);
        return (ints, dbls);
    }
    public void SetConstBulk(int[] integers, double[] doubles)
        => St7Native.St7SetCavityFluidConstBulk(_m.FileId, Id, integers, doubles);

    public (int[] Integers, double[] Doubles) GetIdealGas(int intLen = 4, int doubleLen = 8)
    {
        var ints = new int[intLen]; var dbls = new double[doubleLen];
        St7Native.St7GetCavityFluidIdealGas(_m.FileId, Id, ints, dbls);
        return (ints, dbls);
    }
    public void SetIdealGas(int[] integers, double[] doubles)
        => St7Native.St7SetCavityFluidIdealGas(_m.FileId, Id, integers, doubles);

    /// <summary>Pre-load (Pressure/Volume) applied to the cavity in the given load case.</summary>
    public (int PreType, double Value) GetPreLoad(int loadCase)
        => St7Native.St7GetCavityFluidPreLoad(_m.FileId, Id, loadCase);
    public void SetPreLoad(int loadCase, int preType, double value)
        => St7Native.St7SetCavityFluidPreLoad(_m.FileId, Id, loadCase, preType, value);

    public void Delete() => St7Native.St7DeleteCavityFluidLayout(_m.FileId, Id);
}

