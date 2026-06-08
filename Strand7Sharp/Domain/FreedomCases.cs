using St7API;
namespace Strand7Sharp;
/// <summary>Freedom case definitions. Cases are 1-based.</summary>
public readonly struct FreedomCaseCollection
{
    private readonly St7Model _m;
    internal FreedomCaseCollection(St7Model m) => _m = m;
    public int Count => St7Native.St7GetNumFreedomCase(_m.FileId);
    public FreedomCase this[int caseNum] => new(_m, caseNum);
    public string GetName(int caseNum) => St7Native.St7GetFreedomCaseName(_m.FileId, caseNum);
    public void SetName(int caseNum, string name) => St7Native.St7SetFreedomCaseName(_m.FileId, caseNum, name);
    public int Add(string name)
    {
        St7Native.St7NewFreedomCase(_m.FileId, name);
        return Count;
    }
    public void Delete(int caseNum) => St7Native.St7DeleteFreedomCase(_m.FileId, caseNum);
    /// <summary>Iterate every freedom case (1..Count).</summary>
    public St7Enumerator<FreedomCase> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<FreedomCase>(Count, i => new FreedomCase(m, i));
    }
}

/// <summary>Strongly-typed view onto one freedom case.</summary>
public readonly struct FreedomCase
{
    private readonly St7Model _m;
    public int Number { get; }
    internal FreedomCase(St7Model m, int number) { _m = m; Number = number; }
    public string Name
    {
        get => St7Native.St7GetFreedomCaseName(_m.FileId, Number);
        set => St7Native.St7SetFreedomCaseName(_m.FileId, Number, value);
    }
    public int Type
    {
        get => St7Native.St7GetFreedomCaseType(_m.FileId, Number);
        set => St7Native.St7SetFreedomCaseType(_m.FileId, Number, value);
    }
    public void Delete() => St7Native.St7DeleteFreedomCase(_m.FileId, Number);
}
