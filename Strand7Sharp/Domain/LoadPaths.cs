using St7API;
namespace Strand7Sharp;
/// <summary>
/// Load-path templates defined on the model. Load paths themselves are stored
/// in the model and applied via templates; <see cref="ConvertToLoadCases"/>
/// expands them into discrete load cases.
/// </summary>
public readonly struct LoadPathCollection
{
    private readonly St7Model _m;
    internal LoadPathCollection(St7Model m) => _m = m;

    /// <summary>(NumTemplates, LastTemplateID).</summary>
    public (int NumTemplates, int LastTemplate) Counts => St7Native.St7GetTotalLoadPathTemplates(_m.FileId);

    /// <summary>Number of load-path templates currently defined.</summary>
    public int Count => Counts.NumTemplates;

    /// <summary>Returns the template ID for the given 1-based index.</summary>
    public int GetTemplateIdByIndex(int index) => St7Native.St7GetLoadPathTemplateNumByIndex(_m.FileId, index);

    /// <summary>Handle for a specific template ID.</summary>
    public LoadPathTemplate Template(int templateId) => new(_m, templateId);

    /// <summary>Creates a new load-path template with the given ID and name.</summary>
    public LoadPathTemplate Add(int templateId, string name)
    {
        St7Native.St7NewLoadPathTemplate(_m.FileId, templateId, name);
        return new LoadPathTemplate(_m, templateId);
    }

    /// <summary>Expand all defined load paths into discrete load cases (St7ConvertLoadPathsToLoadCases).</summary>
    public void ConvertToLoadCases(bool pointForces = true, bool distributedForces = true, bool heatSources = true)
        => St7Native.St7ConvertLoadPathsToLoadCases(_m.FileId,
            St7Check.AsByte(pointForces),
            St7Check.AsByte(distributedForces),
            St7Check.AsByte(heatSources));

    /// <summary>Delete a load path (not a template) by ID.</summary>
    public void DeletePath(int loadPathId) => St7Native.St7DeleteLoadPath(_m.FileId, loadPathId);

    /// <summary>Iterate every load-path template (resolves each by index).</summary>
    public St7Enumerator<LoadPathTemplate> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<LoadPathTemplate>(Count, i => new LoadPathTemplate(m, St7Native.St7GetLoadPathTemplateNumByIndex(m.FileId, i)));
    }
}

/// <summary>Strongly-typed view onto one load-path template.</summary>
public readonly struct LoadPathTemplate
{
    private readonly St7Model _m;
    public int Id { get; }
    internal LoadPathTemplate(St7Model m, int id) { _m = m; Id = id; }

    public string Name
    {
        get => St7Native.St7GetLoadPathTemplateName(_m.FileId, Id);
        set => St7Native.St7SetLoadPathTemplateName(_m.FileId, Id, value);
    }

    /// <summary>Raw parameters (integers, doubles) for the template.</summary>
    public (int[] Integers, double[] Doubles) GetParameters(int intLen, int doubleLen)
    {
        var ints = new int[intLen]; var dbls = new double[doubleLen];
        St7Native.St7GetLoadPathTemplateParameters(_m.FileId, Id, ints, dbls);
        return (ints, dbls);
    }
    public void SetParameters(int[] integers, double[] doubles)
        => St7Native.St7SetLoadPathTemplateParameters(_m.FileId, Id, integers, doubles);

    public int NumPointForces(int vehicle = 0) => St7Native.St7GetNumLoadPathTemplatePointForces(_m.FileId, Id, vehicle);
    public int NumDistributedForces(int vehicle = 0) => St7Native.St7GetNumLoadPathTemplateDistributedForces(_m.FileId, Id, vehicle);
    public int NumHeatSources(int vehicle = 0) => St7Native.St7GetNumLoadPathTemplateHeatSources(_m.FileId, Id, vehicle);
    public int NumVehicles => St7Native.St7GetNumLoadPathTemplateVehicles(_m.FileId, Id);

    /// <summary>Delete this template (and remove paths derived from it).</summary>
    public void Delete() => St7Native.St7DeleteLoadPathTemplate(_m.FileId, Id);
}



