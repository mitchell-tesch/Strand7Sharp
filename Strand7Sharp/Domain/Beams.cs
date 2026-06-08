using System;
using St7API;
namespace Strand7Sharp;
/// <summary>Indexed access to the model's beam elements (1-based).</summary>
public readonly struct BeamCollection
{
    private readonly St7Model _m;
    internal BeamCollection(St7Model m) => _m = m;
    public int Count => St7Native.St7GetTotal(_m.FileId, St7.tyBEAM);
    public Beam this[int number] => new(_m, number);
    /// <summary>Creates a beam between two nodes with the given property and returns its number.</summary>
    public int Add(int node1, int node2, int property)
    {
        int n = Count + 1;
        var c = new int[St7.kMaxElementNode];
        c[0] = 2; c[1] = node1; c[2] = node2;
        St7Native.St7SetElementConnection(_m.FileId, St7.tyBEAM, n, property, c);
        return n;
    }
    /// <summary>Iterate every beam in the model (1..Count).</summary>
    public St7Enumerator<Beam> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<Beam>(Count, i => new Beam(m, i));
    }
}
/// <summary>Strongly-typed view onto one beam element.</summary>
public readonly struct Beam
{
    private readonly St7Model _m;
    public int Number { get; }
    internal Beam(St7Model m, int number) { _m = m; Number = number; }
    /// <summary>Property number assigned to this beam.</summary>
    public int Property
    {
        get => St7Native.St7GetElementProperty(_m.FileId, St7.tyBEAM, Number);
        set => St7Native.St7SetElementProperty(_m.FileId, St7.tyBEAM, Number, value);
    }
    /// <summary>Returns the two end-node numbers.</summary>
    public (int Node1, int Node2) Connection
    {
        get
        {
            var c = new int[St7.kMaxElementNode];
            St7Native.St7GetElementConnection(_m.FileId, St7.tyBEAM, Number, c);
            return (c[1], c[2]);
        }
    }
    /// <summary>Group this beam belongs to.</summary>
    public int Group
    {
        get => St7Native.St7GetEntityGroup(_m.FileId, St7.tyBEAM, Number);
        set => St7Native.St7SetEntityGroup(_m.FileId, St7.tyBEAM, Number, value);
    }

    // --- Beam offsets / orientation ---
    /// <summary>Beam end offsets (6 doubles: end1[x,y,z], end2[x,y,z]).</summary>
    public double[] Offset
    {
        get { var d = new double[6]; St7Native.St7GetBeamOffset2(_m.FileId, Number, d); return d; }
        set => St7Native.St7SetBeamOffset2(_m.FileId, Number, value);
    }

    /// <summary>Per-beam section property factors (7-value buffer).</summary>
    public double[] SectionFactors
    {
        get { var d = new double[7]; St7Native.St7GetBeamSectionFactor7(_m.FileId, Number, d); return d; }
        set => St7Native.St7SetBeamSectionFactor7(_m.FileId, Number, value);
    }

    // --- End releases ---
    /// <summary>Translational end release flags + spring stiffness at the given beam end.</summary>
    public (int[] Status, double[] Stiffness) GetTranslationRelease(int beamEnd)
    {
        var s = new int[3]; var d = new double[3];
        St7Native.St7GetBeamTRelease3(_m.FileId, Number, beamEnd, s, d);
        return (s, d);
    }
    public void SetTranslationRelease(int beamEnd, int[] status, double[] stiffness)
        => St7Native.St7SetBeamTRelease3(_m.FileId, Number, beamEnd, status, stiffness);

    public (int[] Status, double[] Stiffness) GetRotationRelease(int beamEnd)
    {
        var s = new int[3]; var d = new double[3];
        St7Native.St7GetBeamRRelease3(_m.FileId, Number, beamEnd, s, d);
        return (s, d);
    }
    public void SetRotationRelease(int beamEnd, int[] status, double[] stiffness)
        => St7Native.St7SetBeamRRelease3(_m.FileId, Number, beamEnd, status, stiffness);

    // --- Loads ---
    /// <summary>Apply a distributed force on the beam in global directions (St7SetBeamDistributedForceGlobal6ID).</summary>
    public void SetDistributedForceGlobal(int loadCase, int beamDir, int projectFlag, int loadType, int id, double[] values)
        => St7Native.St7SetBeamDistributedForceGlobal6ID(_m.FileId, Number, beamDir, projectFlag, loadCase, loadType, id, values);

    /// <summary>Apply a pre-load (axial / strain / etc.) on the beam.</summary>
    public void SetPreLoad(int loadCase, int loadType, double[] values)
        => St7Native.St7SetBeamPreLoad1(_m.FileId, Number, loadCase, loadType, values);

    public void SetPreCurvature(int loadCase, double[] values)
        => St7Native.St7SetBeamPreCurvature2(_m.FileId, Number, loadCase, values);

    /// <summary>Beam temperature gradient in the given load case (2 values).</summary>
    public void SetTemperatureGradient(int loadCase, double dT_dY, double dT_dZ)
        => St7Native.St7SetBeamTempGradient2(_m.FileId, Number, loadCase, new[] { dT_dY, dT_dZ });
    public (double dTdY, double dTdZ) GetTemperatureGradient(int loadCase)
    {
        var d = new double[2]; St7Native.St7GetBeamTempGradient2(_m.FileId, Number, loadCase, d);
        return (d[0], d[1]);
    }

    /// <summary>Geometric centroid of the beam.</summary>
    public Vector3 Centroid
    {
        get { var d = new double[3]; St7Native.St7GetElementCentroid(_m.FileId, St7.tyBEAM, Number, 0, d); return Vector3.FromArray(d); }
    }

    /// <summary>Non-structural mass attribute (10 doubles per attribute id).
    /// <paramref name="dlType"/> is one of the <c>dl*</c> beam distribution constants
    /// (<c>St7.dlConstant</c>, <c>dlLinear</c>, <c>dlTriangular</c>, ...).</summary>
    public void SetNonStructuralMass(int loadCase, int attributeId, int dlType, double[] data)
        => St7Native.St7SetBeamNSMass10ID(_m.FileId, Number, loadCase, dlType, attributeId, data);
    /// <summary>Returns the distribution type and the 10 doubles describing the non-structural mass.</summary>
    public (int DlType, double[] Data) GetNonStructuralMass(int loadCase, int attributeId)
    {
        var d = new double[10];
        int dlType = St7Native.St7GetBeamNSMass10ID(_m.FileId, Number, loadCase, attributeId, d);
        return (dlType, d);
    }
}
