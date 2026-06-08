using St7API;
namespace Strand7Sharp;
/// <summary>Indexed access to the model's geometry edges and co-edges.</summary>
public readonly struct GeometryEdgeCollection
{
    private readonly St7Model _m;
    internal GeometryEdgeCollection(St7Model m) => _m = m;
    /// <summary>Total number of geometry edges in the model.</summary>
    public int Count => St7Native.St7GetTotal(_m.FileId, St7.tyGEOMETRYEDGE);
    /// <summary>Total number of geometry co-edges in the model.</summary>
    public int CoedgeCount => St7Native.St7GetTotal(_m.FileId, St7.tyGEOMETRYCOEDGE);
    public GeometryEdge this[int number] => new(_m, number);
    /// <summary>Returns the co-edge handle for the given 1-based co-edge number.</summary>
    public GeometryCoedge Coedge(int coedgeNum) => new(_m, coedgeNum);
    /// <summary>Iterate every geometry edge.</summary>
    public St7Enumerator<GeometryEdge> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<GeometryEdge>(Count, i => new GeometryEdge(m, i));
    }
    /// <summary>Iterate every geometry co-edge.</summary>
    public St7Enumerator<GeometryCoedge> EnumerateCoedges()
    {
        var m = _m;
        return new St7Enumerator<GeometryCoedge>(CoedgeCount, i => new GeometryCoedge(m, i));
    }
}

/// <summary>Strongly-typed view onto one geometry edge.</summary>
public readonly struct GeometryEdge
{
    private readonly St7Model _m;
    public int Number { get; }
    internal GeometryEdge(St7Model m, int number) { _m = m; Number = number; }

    /// <summary>Group this edge belongs to.</summary>
    public int Group
    {
        get => St7Native.St7GetEntityGroup(_m.FileId, St7.tyGEOMETRYEDGE, Number);
        set => St7Native.St7SetEntityGroup(_m.FileId, St7.tyGEOMETRYEDGE, Number, value);
    }
}

/// <summary>Strongly-typed view onto one geometry co-edge (one side of an edge).</summary>
public readonly struct GeometryCoedge
{
    private readonly St7Model _m;
    public int Number { get; }
    internal GeometryCoedge(St7Model m, int number) { _m = m; Number = number; }

    /// <summary>Parent edge number for this co-edge.</summary>
    public int Edge => St7Native.St7GetGeometryCoedgeEdge(_m.FileId, Number);

    /// <summary>Group this co-edge belongs to.</summary>
    public int Group
    {
        get => St7Native.St7GetEntityGroup(_m.FileId, St7.tyGEOMETRYCOEDGE, Number);
        set => St7Native.St7SetEntityGroup(_m.FileId, St7.tyGEOMETRYCOEDGE, Number, value);
    }

    /// <summary>Co-edge release flags (one int per DOF, St7GetGeometryCoedgeRelease1).</summary>
    public int[] Release
    {
        get { var s = new int[6]; St7Native.St7GetGeometryCoedgeRelease1(_m.FileId, Number, s); return s; }
        set => St7Native.St7SetGeometryCoedgeRelease1(_m.FileId, Number, value);
    }
}

