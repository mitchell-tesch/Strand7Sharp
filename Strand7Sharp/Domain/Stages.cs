using System.Collections.Generic;
using St7API;
namespace Strand7Sharp;
/// <summary>Construction-staging cases (stage 1..N).</summary>
public readonly struct StageCollection
{
    private readonly St7Model _m;
    internal StageCollection(St7Model m) => _m = m;

    public int Count => St7Native.St7GetNumStages(_m.FileId);
    public Stage this[int stage] => new(_m, stage);

    /// <summary>Append a new stage with the given name and integer flags (St7AddStage).</summary>
    public int Add(string name, int[]? integers = null)
    {
        St7Native.St7AddStage(_m.FileId, name, integers ?? new int[5]);
        return Count;
    }

    /// <summary>Append a new stage with the given flags (sets ipStage* slots accordingly).</summary>
    public int Add(string name,
        bool morph = false,
        bool moveFixedNodes = false,
        bool rotateClusters = false,
        bool setFluidLevel = false,
        bool reset = false)
    {
        var ints = new int[5]
        {
            morph ? St7.btTrue : St7.btFalse,
            moveFixedNodes ? St7.btTrue : St7.btFalse,
            rotateClusters ? St7.btTrue : St7.btFalse,
            setFluidLevel ? St7.btTrue : St7.btFalse,
            reset ? St7.btTrue : St7.btFalse,
        };
        St7Native.St7AddStage(_m.FileId, name, ints);
        return Count;
    }

    /// <summary>Insert a stage before the given 1-based index.</summary>
    public void Insert(int stage, string name, int[]? integers = null)
        => St7Native.St7InsertStage(_m.FileId, stage, name, integers ?? new int[5]);

    public void Delete(int stage) => St7Native.St7DeleteStage(_m.FileId, stage);

    /// <summary>Get / set whether NLA staged analysis is enabled.</summary>
    public bool StagedAnalysisEnabled
    {
        get => St7Native.St7GetNLAStagedAnalysis(_m.FileId) != 0;
        set => St7Native.St7SetNLAStagedAnalysis(_m.FileId, St7Check.AsByte(value));
    }

    /// <summary>Currently-active stage for the solver.</summary>
    public int SolverActiveStage
    {
        get => St7Native.St7GetSolverActiveStage(_m.FileId);
        set => St7Native.St7SetSolverActiveStage(_m.FileId, value);
    }
    /// <summary>Iterate every stage in the model (1..Count).</summary>
    public St7Enumerator<Stage> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<Stage>(Count, i => new Stage(m, i));
    }

    /// <summary>
    /// Materialise the full Stages × Groups activation matrix in one pass.
    /// The returned dictionary is keyed on <c>(GroupId, Stage)</c> and holds
    /// <c>true</c> when the group is enabled in that stage. Useful when a
    /// caller needs the raw matrix rather than a per-group lifecycle.
    /// </summary>
    public IReadOnlyDictionary<(int GroupId, int Stage), bool> BuildEnabledMatrix()
    {
        var totalStages = Count;
        var groups = new GroupCollection(_m);
        var totalGroups = groups.Count;

        var matrix = new Dictionary<(int, int), bool>(totalStages * totalGroups);
        for (var i = 1; i <= totalGroups; i++)
        {
            var groupId = groups.GetByIndex(i).GroupID;
            for (var s = 1; s <= totalStages; s++)
                matrix[(groupId, s)] = St7Native.St7GetStageGroupState(_m.FileId, s, groupId) != 0;
        }
        return matrix;
    }
}

/// <summary>Strongly-typed view onto one construction stage.</summary>
public readonly struct Stage
{
    private readonly St7Model _m;
    public int Number { get; }
    internal Stage(St7Model m, int number) { _m = m; Number = number; }

    public string Name
    {
        get => St7Native.St7GetStageName(_m.FileId, Number);
        set => St7Native.St7SetStageName(_m.FileId, Number, value);
    }

    /// <summary>Stage integer-flags buffer (length per St7 docs).</summary>
    public int[] Data
    {
        get { var b = new int[5]; St7Native.St7GetStageData(_m.FileId, Number, b); return b; }
        set => St7Native.St7SetStageData(_m.FileId, Number, value);
    }

    /// <summary>Optional fluid level for the stage.</summary>
    public double FluidLevel
    {
        get => St7Native.St7GetStageFluidLevel(_m.FileId, Number);
        set => St7Native.St7SetStageFluidLevel(_m.FileId, Number, value);
    }

    /// <summary>Whether the given group is enabled in this stage.</summary>
    public bool IsGroupEnabled(int groupId) => St7Native.St7GetStageGroupState(_m.FileId, Number, groupId) != 0;
    public void EnableGroup(int groupId) => St7Native.St7EnableStageGroup(_m.FileId, Number, groupId);
    public void DisableGroup(int groupId) => St7Native.St7DisableStageGroup(_m.FileId, Number, groupId);

    public bool IsNLAEnabled
    {
        get => St7Native.St7GetNLAStageState(_m.FileId, Number) != 0;
        set { if (value) St7Native.St7EnableNLAStage(_m.FileId, Number); else St7Native.St7DisableNLAStage(_m.FileId, Number); }
    }

    /// <summary>NLA load-step increments scoped to this stage.</summary>
    public NLAIncrementCollection NLAIncrements => new(_m, Number);
}

