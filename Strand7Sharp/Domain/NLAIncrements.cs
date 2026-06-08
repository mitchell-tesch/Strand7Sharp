using St7API;
namespace Strand7Sharp;

/// <summary>
/// Per-stage NLA load-step increments. Strand7's NLA breaks each stage into
/// numbered increments (1..N); each increment has per-load-case and
/// per-freedom-case scale factors.
/// </summary>
public readonly struct NLAIncrementCollection
{
    private readonly St7Model _m;
    /// <summary>1-based stage number that hosts these increments.</summary>
    public int Stage { get; }
    internal NLAIncrementCollection(St7Model m, int stage) { _m = m; Stage = stage; }

    public int Count => St7Native.St7GetNumNLAIncrements(_m.FileId, Stage);

    /// <summary>Returns the name of the given (1-based) increment.</summary>
    public string GetName(int increment) => St7Native.St7GetNLAIncrementName(_m.FileId, Stage, increment);

    /// <summary>Append a new increment to this stage. Returns its new number.</summary>
    public int Add(string name)
    {
        St7Native.St7AddNLAIncrement(_m.FileId, Stage, name);
        return Count;
    }
    public void Insert(int increment, string name) => St7Native.St7InsertNLAIncrement(_m.FileId, Stage, increment, name);
    public void Delete(int increment) => St7Native.St7DeleteNLAIncrement(_m.FileId, Stage, increment);

    /// <summary>Load-case scale factor applied at this increment for the given load case.</summary>
    public double GetLoadFactor(int increment, int loadCase) => St7Native.St7GetNLALoadIncrementFactor(_m.FileId, Stage, increment, loadCase);
    public void SetLoadFactor(int increment, int loadCase, double factor)
        => St7Native.St7SetNLALoadIncrementFactor(_m.FileId, Stage, increment, loadCase, factor);
    /// <summary>Freedom-case scale factor applied at this increment.</summary>
    public double GetFreedomFactor(int increment, int freedomCase) => St7Native.St7GetNLAFreedomIncrementFactor(_m.FileId, Stage, increment, freedomCase);
    public void SetFreedomFactor(int increment, int freedomCase, double factor)
        => St7Native.St7SetNLAFreedomIncrementFactor(_m.FileId, Stage, increment, freedomCase, factor);

    /// <summary>Whether the increment is a "reset" point in the NLA history.</summary>
    public bool GetReset(int increment) => St7Native.St7GetNLAResetAtIncrement(_m.FileId, increment) != 0;
    public void SetReset(int increment, bool reset)
        => St7Native.St7SetNLAResetAtIncrement(_m.FileId, increment, St7Check.AsByte(reset));
}

