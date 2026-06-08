using System;
using St7API;
namespace Strand7Sharp;
/// <summary>Indexed access to the model's geometry faces (1-based).</summary>
public readonly struct GeometryFaceCollection
{
    private readonly St7Model _m;
    internal GeometryFaceCollection(St7Model m) => _m = m;
    public int Count => St7Native.St7GetTotal(_m.FileId, St7.tyGEOMETRYFACE);
    public GeometryFace this[int number] => new(_m, number);
    /// <summary>Iterate every geometry face.</summary>
    public St7Enumerator<GeometryFace> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<GeometryFace>(Count, i => new GeometryFace(m, i));
    }
}
/// <summary>Strongly-typed view onto one geometry face.</summary>
public readonly struct GeometryFace
{
    private readonly St7Model _m;
    public int Number { get; }
    internal GeometryFace(St7Model m, int number) { _m = m; Number = number; }

    /// <summary>Plate property number applied to this face (St7GetGeometryFaceProperty).</summary>
    public int Property
    {
        get => St7Native.St7GetGeometryFaceProperty(_m.FileId, Number);
        set => St7Native.St7SetGeometryFaceProperty(_m.FileId, Number, value);
    }

    /// <summary>Persistent face ID assigned by the geometry kernel.</summary>
    public int Id
    {
        get => St7Native.St7GetGeometryFaceID(_m.FileId, Number);
        set => St7Native.St7SetGeometryFaceID(_m.FileId, Number, value);
    }

    /// <summary>Group this face belongs to.</summary>
    public int Group
    {
        get => St7Native.St7GetEntityGroup(_m.FileId, St7.tyGEOMETRYFACE, Number);
        set => St7Native.St7SetEntityGroup(_m.FileId, St7.tyGEOMETRYFACE, Number, value);
    }

    /// <summary>Underlying analytical surface number (St7GetGeometryFaceSurface).</summary>
    public int Surface => St7Native.St7GetGeometryFaceSurface(_m.FileId, Number);

    /// <summary>Returns the vertex numbers that bound this face.</summary>
    public int[] Vertices
    {
        get
        {
            int n = St7Native.St7GetNumGeometryFaceVertices(_m.FileId, Number);
            var v = new int[n];
            if (n > 0) St7Native.St7GetGeometryFaceVertices(_m.FileId, Number, n, v);
            return v;
        }
    }
    public int[] Edges
    {
        get
        {
            int n = St7Native.St7GetNumGeometryFaceEdges(_m.FileId, Number);
            var e = new int[n];
            if (n > 0) St7Native.St7GetGeometryFaceEdges(_m.FileId, Number, n, e);
            return e;
        }
    }
    public int[] Coedges
    {
        get
        {
            int n = St7Native.St7GetNumGeometryFaceCoedges(_m.FileId, Number);
            var c = new int[n];
            if (n > 0) St7Native.St7GetGeometryFaceCoedges(_m.FileId, Number, n, c);
            return c;
        }
    }

    /// <summary>Plate-shell thickness attribute on this face (2-value: top/bottom).</summary>
    public (double Top, double Bottom) Thickness
    {
        get
        {
            var d = new double[2];
            St7Native.St7GetGeometryFaceThickness2(_m.FileId, Number, d);
            return (d[0], d[1]);
        }
        set => St7Native.St7SetGeometryFaceThickness2(_m.FileId, Number, new[] { value.Top, value.Bottom });
    }

    public (double Membrane, double Bending) Offset
    {
        get
        {
            var d = new double[2];
            St7Native.St7GetGeometryFaceOffset1(_m.FileId, Number, d);
            return (d[0], d[1]);
        }
        set => St7Native.St7SetGeometryFaceOffset1(_m.FileId, Number, new[] { value.Membrane, value.Bending });
    }

    /// <summary>Set a normal pressure attribute on the face for the given load case.</summary>
    public void SetNormalPressure(int loadCase, double pressure, double thicknessRatio = 0.5)
        => St7Native.St7SetGeometryFaceNormalPressure2(_m.FileId, Number, loadCase, new[] { pressure, thicknessRatio });

    public (double Pressure, double ThicknessRatio) GetNormalPressure(int loadCase)
    {
        var d = new double[2];
        St7Native.St7GetGeometryFaceNormalPressure2(_m.FileId, Number, loadCase, d);
        return (d[0], d[1]);
    }

    /// <summary>Heat-source attribute on the face for the given load case.</summary>
    public void SetHeatSource(int loadCase, double q) => St7Native.St7SetGeometryFaceHeatSource1(_m.FileId, Number, loadCase, new[] { q });
    public double GetHeatSource(int loadCase)
    {
        var d = new double[1]; St7Native.St7GetGeometryFaceHeatSource1(_m.FileId, Number, loadCase, d);
        return d[0];
    }

    /// <summary>Non-structural mass attribute (5 doubles per attribute id).</summary>
    public void SetNonStructuralMass(int loadCase, int attributeId, double[] data)
        => St7Native.St7SetGeometryFaceNSMass5ID(_m.FileId, Number, loadCase, attributeId, data);
    public double[] GetNonStructuralMass(int loadCase, int attributeId)
    {
        var d = new double[5];
        St7Native.St7GetGeometryFaceNSMass5ID(_m.FileId, Number, loadCase, attributeId, d);
        return d;
    }
}

