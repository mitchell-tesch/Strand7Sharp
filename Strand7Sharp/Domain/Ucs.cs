using St7API;
namespace Strand7Sharp;
/// <summary>User-defined coordinate systems (UCS).</summary>
public readonly struct UcsCollection
{
    private readonly St7Model _m;
    internal UcsCollection(St7Model m) => _m = m;
    /// <summary>Total number of user coordinate systems currently defined.</summary>
    public int Count => St7Native.St7GetNumUCS(_m.FileId);

    /// <summary>Returns the UCS ID at the given 1-based index.</summary>
    public int GetIdByIndex(int index) => St7Native.St7GetUCSID(_m.FileId, index);

    /// <summary>Get / set the human-readable name of a UCS.</summary>
    public string GetName(int ucsId) => St7Native.St7GetUCSName(_m.FileId, ucsId);
    public void SetName(int ucsId, string name) => St7Native.St7SetUCSName(_m.FileId, ucsId, name);

    /// <summary>Returns (UCS type, parameters). The number of meaningful parameters depends on the type.</summary>
    public (int Type, double[] Parameters) Get(int ucsId)
    {
        var doubles = new double[St7.kMaxUCSDoubles];
        var type = St7Native.St7GetUCS(_m.FileId, ucsId, doubles);
        return (type, doubles);
    }
    public void Set(int ucsId, int ucsType, double[] parameters)
        => St7Native.St7SetUCS(_m.FileId, ucsId, ucsType, parameters);
    public void Delete(int ucsId) => St7Native.St7DeleteUCS(_m.FileId, ucsId);

    /// <summary>Transforms a global XYZ to the given UCS in-place.</summary>
    public void TransformToUCS(int ucsId, double[] xyz)
        => St7Native.St7TransformToUCS(_m.FileId, ucsId, xyz);

    /// <summary>Transforms a vector at a position from global to the given UCS in-place.</summary>
    public void VectorTransformToUCS(int ucsId, double[] position, double[] vector)
        => St7Native.St7VectorTransformToUCS(_m.FileId, ucsId, position, vector);

    /// <summary>Iterate every UCS ID (1..Count via St7GetUCSID).</summary>
    public St7Enumerator<int> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<int>(Count, i => St7Native.St7GetUCSID(m.FileId, i));
    }
}

