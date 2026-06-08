using System;
using St7API;
namespace Strand7Sharp;
/// <summary>Indexed access to the model's plate elements (1-based).</summary>
public readonly struct PlateCollection
{
    private readonly St7Model _m;
    internal PlateCollection(St7Model m) => _m = m;
    public int Count => St7Native.St7GetTotal(_m.FileId, St7.tyPLATE);
    public Plate this[int number] => new(_m, number);
    /// <summary>Creates a plate from the given corner node numbers (3, 4, 6, 8 or 9 nodes) and returns its number.</summary>
    public int Add(int property, params int[] cornerNodes)
    {
        if (cornerNodes is null || cornerNodes.Length == 0)
            throw new ArgumentException("At least one corner node is required.", nameof(cornerNodes));
        if (cornerNodes.Length > St7.kMaxElementNode - 1)
            throw new ArgumentException($"Too many corner nodes (max {St7.kMaxElementNode - 1}).", nameof(cornerNodes));
        int n = Count + 1;
        var c = new int[St7.kMaxElementNode];
        c[0] = cornerNodes.Length;
        Array.Copy(cornerNodes, 0, c, 1, cornerNodes.Length);
        St7Native.St7SetElementConnection(_m.FileId, St7.tyPLATE, n, property, c);
        return n;
    }
    /// <summary>Iterate every plate in the model.</summary>
    public St7Enumerator<Plate> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<Plate>(Count, i => new Plate(m, i));
    }
}
/// <summary>Strongly-typed view onto one plate element.</summary>
public readonly struct Plate
{
    private readonly St7Model _m;
    public int Number { get; }
    internal Plate(St7Model m, int number) { _m = m; Number = number; }
    public int Property
    {
        get => St7Native.St7GetElementProperty(_m.FileId, St7.tyPLATE, Number);
        set => St7Native.St7SetElementProperty(_m.FileId, St7.tyPLATE, Number, value);
    }
    /// <summary>Returns the corner-node numbers (3, 4, 6, 8 or 9 depending on element type).</summary>
    public int[] Connection
    {
        get
        {
            var c = new int[St7.kMaxElementNode];
            St7Native.St7GetElementConnection(_m.FileId, St7.tyPLATE, Number, c);
            int n = c[0];
            var r = new int[n];
            Array.Copy(c, 1, r, 0, n);
            return r;
        }
    }
    public int Group
    {
        get => St7Native.St7GetEntityGroup(_m.FileId, St7.tyPLATE, Number);
        set => St7Native.St7SetEntityGroup(_m.FileId, St7.tyPLATE, Number, value);
    }

    /// <summary>Plate thickness attribute (top, bottom).</summary>
    public (double Top, double Bottom) Thickness
    {
        get { var d = new double[2]; St7Native.St7GetPlateThickness2(_m.FileId, Number, d); return (d[0], d[1]); }
        set => St7Native.St7SetPlateThickness2(_m.FileId, Number, new[] { value.Top, value.Bottom });
    }

    /// <summary>Plate offset (1 value: distance from mid-surface).</summary>
    public double Offset
    {
        get { var d = new double[1]; St7Native.St7GetPlateOffset1(_m.FileId, Number, d); return d[0]; }
        set => St7Native.St7SetPlateOffset1(_m.FileId, Number, new[] { value });
    }

    // --- Loads ---
    /// <summary>Apply a constant normal pressure on top &amp; bottom faces in the given load case.</summary>
    public void SetNormalPressure(int loadCase, double pressureTop, double pressureBottom)
        => St7Native.St7SetPlateNormalPressure2(_m.FileId, Number, loadCase, new[] { pressureTop, pressureBottom });
    public (double Top, double Bottom) GetNormalPressure(int loadCase)
    {
        var d = new double[2]; St7Native.St7GetPlateNormalPressure2(_m.FileId, Number, loadCase, d);
        return (d[0], d[1]);
    }

    /// <summary>Apply a 3-component global pressure on the given surface (1 = top, 2 = bottom).</summary>
    public void SetGlobalPressure(int loadCase, int surface, bool project, Vector3 pressure)
        => St7Native.St7SetPlateGlobalPressure3S(_m.FileId, Number, surface,
            St7Check.AsByte(project), loadCase, pressure.ToArray());

    /// <summary>Heat-source attribute (St7SetPlateHeatSource1).</summary>
    public void SetHeatSource(int loadCase, double q)
        => St7Native.St7SetPlateHeatSource1(_m.FileId, Number, loadCase, new[] { q });
    public double GetHeatSource(int loadCase)
    {
        var d = new double[1]; St7Native.St7GetPlateHeatSource1(_m.FileId, Number, loadCase, d);
        return d[0];
    }

    /// <summary>Plate edge-release flags on the given (1-based) edge.</summary>
    public int[] GetEdgeRelease(int edge)
    {
        var s = new int[6];
        St7Native.St7GetPlateEdgeRelease1(_m.FileId, Number, edge, s);
        return s;
    }
    public void SetEdgeRelease(int edge, int[] status)
        => St7Native.St7SetPlateEdgeRelease1(_m.FileId, Number, edge, status);

    /// <summary>Apply a pressure on a single plate edge (St7SetPlateEdgePressure1).</summary>
    public void SetEdgePressure(int loadCase, int edge, double pressure)
        => St7Native.St7SetPlateEdgePressure1(_m.FileId, Number, loadCase, edge, new[] { pressure });

    /// <summary>Geometric centroid of the plate (faceEdge=0 = the whole element).</summary>
    public Vector3 Centroid
    {
        get { var d = new double[3]; St7Native.St7GetElementCentroid(_m.FileId, St7.tyPLATE, Number, 0, d); return Vector3.FromArray(d); }
    }

    /// <summary>Non-structural mass (5 doubles per attribute id).</summary>
    public void SetNonStructuralMass(int loadCase, int attributeId, double[] data)
        => St7Native.St7SetPlateNSMass5ID(_m.FileId, Number, loadCase, attributeId, data);
    public double[] GetNonStructuralMass(int loadCase, int attributeId)
    {
        var d = new double[5];
        St7Native.St7GetPlateNSMass5ID(_m.FileId, Number, loadCase, attributeId, d);
        return d;
    }

    /// <summary>Cavity-fluid layout ID assigned on the given surface (1=top, 2=bottom).</summary>
    public int GetCavityFluid(int surface) => St7Native.St7GetPlateCavityFluid(_m.FileId, Number, surface);
    public void SetCavityFluid(int surface, int cavityId)
        => St7Native.St7SetPlateCavityFluid(_m.FileId, Number, surface, cavityId);
}
