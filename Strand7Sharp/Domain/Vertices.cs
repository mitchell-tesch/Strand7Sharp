using System;
using St7API;
namespace Strand7Sharp;
/// <summary>Indexed access to the model's geometry vertices (1-based).</summary>
public readonly struct VertexCollection
{
    private readonly St7Model _m;
    internal VertexCollection(St7Model m) => _m = m;
    /// <summary>Total number of vertices.</summary>
    public int Count => St7Native.St7GetTotal(_m.FileId, St7.tyVERTEX);
    /// <summary>Returns a lightweight handle for the vertex with the given 1-based number.</summary>
    public Vertex this[int number] => new(_m, number);
    /// <summary>Iterate every vertex in the model.</summary>
    public St7Enumerator<Vertex> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<Vertex>(Count, i => new Vertex(m, i));
    }
}
/// <summary>Strongly-typed view onto one geometry vertex.</summary>
public readonly struct Vertex
{
    private readonly St7Model _m;
    public int Number { get; }
    internal Vertex(St7Model m, int number) { _m = m; Number = number; }

    /// <summary>Cartesian coordinates of the vertex (read-only — drives geometry).</summary>
    public Vector3 XYZ
    {
        get
        {
            var xyz = new double[3];
            St7Native.St7GetVertexXYZ(_m.FileId, Number, xyz);
            return Vector3.FromArray(xyz);
        }
    }

    /// <summary>Persistent vertex ID assigned by the geometry kernel.</summary>
    public int Id
    {
        get => St7Native.St7GetVertexID(_m.FileId, Number);
        set => St7Native.St7SetVertexID(_m.FileId, Number, value);
    }

    /// <summary>Vertex topological type (St7GetVertexType).</summary>
    public int Type
    {
        get => St7Native.St7GetVertexType(_m.FileId, Number);
        set => St7Native.St7SetVertexType(_m.FileId, Number, value);
    }

    /// <summary>Group this vertex belongs to.</summary>
    public int Group
    {
        get => St7Native.St7GetEntityGroup(_m.FileId, St7.tyVERTEX, Number);
        set => St7Native.St7SetEntityGroup(_m.FileId, St7.tyVERTEX, Number, value);
    }

    /// <summary>Mesh seed size at this vertex (St7GetVertexMeshSize1).</summary>
    public double MeshSize
    {
        get
        {
            var d = new double[1];
            St7Native.St7GetVertexMeshSize1(_m.FileId, Number, d);
            return d[0];
        }
        set => St7Native.St7SetVertexMeshSize1(_m.FileId, Number, new[] { value });
    }

    /// <summary>Apply a 3-component force in the given load case.</summary>
    public void SetForce(int loadCase, Vector3 force)
        => St7Native.St7SetVertexForce3(_m.FileId, Number, loadCase, force.ToArray());
    public Vector3 GetForce(int loadCase)
    {
        var d = new double[3]; St7Native.St7GetVertexForce3(_m.FileId, Number, loadCase, d);
        return Vector3.FromArray(d);
    }
    public void SetMoment(int loadCase, Vector3 moment)
        => St7Native.St7SetVertexMoment3(_m.FileId, Number, loadCase, moment.ToArray());
    public Vector3 GetMoment(int loadCase)
    {
        var d = new double[3]; St7Native.St7GetVertexMoment3(_m.FileId, Number, loadCase, d);
        return Vector3.FromArray(d);
    }

    /// <summary>Set the 6-DOF restraint status and prescribed values at the vertex.</summary>
    public void SetRestraint(int freedomCase, int ucsId, DofStatus status, DofValues values)
        => St7Native.St7SetVertexRestraint6(_m.FileId, Number, freedomCase, ucsId, status.ToArray(), values.ToArray());
    public (int UcsId, DofStatus Status, DofValues Values) GetRestraint(int freedomCase)
    {
        var status = new int[6]; var values = new double[6];
        int ucs = St7Native.St7GetVertexRestraint6(_m.FileId, Number, freedomCase, status, values);
        return (ucs, DofStatus.FromArray(status), DofValues.FromArray(values));
    }
    /// <summary>Fully fix all 6 DOFs at the vertex.</summary>
    public void Fix(int freedomCase, int ucsId = 1)
        => SetRestraint(freedomCase, ucsId, DofStatus.Fixed, DofValues.Zero);

    /// <summary>Translational mass (single value).</summary>
    public double TranslationalMass
    {
        set => St7Native.St7SetVertexTMass1(_m.FileId, Number, value);
    }
    public void SetTranslationalMass3(Vector3 mass) => St7Native.St7SetVertexTMass3(_m.FileId, Number, mass.ToArray());

    /// <summary>Temperature attribute for the load case (St7SetVertexTemperature1).</summary>
    public void SetTemperature(int loadCase, double temperature)
        => St7Native.St7SetVertexTemperature1(_m.FileId, Number, loadCase, new[] { temperature });
    public double GetTemperature(int loadCase)
    {
        var d = new double[1]; St7Native.St7GetVertexTemperature1(_m.FileId, Number, loadCase, d);
        return d[0];
    }
    public NodeTemperatureType GetTemperatureType(int loadCase)
        => (NodeTemperatureType)St7Native.St7GetVertexTemperatureType1(_m.FileId, Number, loadCase);
    public void SetTemperatureType(int loadCase, NodeTemperatureType type)
        => St7Native.St7SetVertexTemperatureType1(_m.FileId, Number, loadCase, (int)type);

    /// <summary>Concentrated heat source attribute for the load case.</summary>
    public void SetHeatSource(int loadCase, double heat)
        => St7Native.St7SetVertexHeatSource1(_m.FileId, Number, loadCase, new[] { heat });
    public double GetHeatSource(int loadCase)
    {
        var d = new double[1]; St7Native.St7GetVertexHeatSource1(_m.FileId, Number, loadCase, d);
        return d[0];
    }

    /// <summary>Non-structural mass attribute (5 doubles per attribute id).</summary>
    public void SetNonStructuralMass(int loadCase, int attributeId, double[] data)
        => St7Native.St7SetVertexNSMass5ID(_m.FileId, Number, loadCase, attributeId, data);
    public double[] GetNonStructuralMass(int loadCase, int attributeId)
    {
        var d = new double[5];
        St7Native.St7GetVertexNSMass5ID(_m.FileId, Number, loadCase, attributeId, d);
        return d;
    }
}

