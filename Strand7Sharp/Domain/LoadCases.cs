using St7API;
namespace Strand7Sharp;
/// <summary>Load case definitions. Cases are 1-based.</summary>
public readonly struct LoadCaseCollection
{
    private readonly St7Model _m;
    internal LoadCaseCollection(St7Model m) => _m = m;
    /// <summary>Total number of load cases.</summary>
    public int Count => St7Native.St7GetNumLoadCase(_m.FileId);
    /// <summary>Get a strongly-typed handle for the given 1-based load-case index.</summary>
    public LoadCase this[int caseNum] => new(_m, caseNum);
    /// <summary>Get or set the load case name at the given (1-based) index.</summary>
    public string GetName(int caseNum) => St7Native.St7GetLoadCaseName(_m.FileId, caseNum);
    public void SetName(int caseNum, string name) => St7Native.St7SetLoadCaseName(_m.FileId, caseNum, name);
    /// <summary>Creates a new load case and returns its 1-based number.</summary>
    public int Add(string name)
    {
        St7Native.St7NewLoadCase(_m.FileId, name);
        return Count;
    }
    public void Delete(int caseNum) => St7Native.St7DeleteLoadCase(_m.FileId, caseNum);
    /// <summary>Iterate every load case (1..Count).</summary>
    public St7Enumerator<LoadCase> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<LoadCase>(Count, i => new LoadCase(m, i));
    }
}

/// <summary>Strongly-typed view onto one load case.</summary>
public readonly struct LoadCase
{
    private readonly St7Model _m;
    public int Number { get; }
    internal LoadCase(St7Model m, int number) { _m = m; Number = number; }
    public string Name
    {
        get => St7Native.St7GetLoadCaseName(_m.FileId, Number);
        set => St7Native.St7SetLoadCaseName(_m.FileId, Number, value);
    }
    /// <summary>Load case type code (St7.lt*).</summary>
    public int Type
    {
        get => St7Native.St7GetLoadCaseType(_m.FileId, Number);
        set => St7Native.St7SetLoadCaseType(_m.FileId, Number, value);
    }
    /// <summary>Gravity-direction axis (1=X, 2=Y, 3=Z).</summary>
    public int GravityDir
    {
        get => St7Native.St7GetLoadCaseGravityDir(_m.FileId, Number);
        set => St7Native.St7SetLoadCaseGravityDir(_m.FileId, Number, value);
    }
    /// <summary>Gravitational acceleration magnitude.</summary>
    public double Gravity
    {
        get => St7Native.St7GetLoadCaseGravity(_m.FileId, Number);
        set => St7Native.St7SetLoadCaseGravity(_m.FileId, Number, value);
    }
    public void Delete() => St7Native.St7DeleteLoadCase(_m.FileId, Number);
}
