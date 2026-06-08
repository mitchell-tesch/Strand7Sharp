using System;
using St7API;
namespace Strand7Sharp;
/// <summary>Indexed access to the model's brick elements (1-based).</summary>
public readonly struct BrickCollection
{
    private readonly St7Model _m;
    internal BrickCollection(St7Model m) => _m = m;
    public int Count => St7Native.St7GetTotal(_m.FileId, St7.tyBRICK);
    public Brick this[int number] => new(_m, number);
    /// <summary>Creates a brick from the given corner node numbers (4, 5, 6, 8, 10, 15, or 20 nodes) and returns its number.</summary>
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
        St7Native.St7SetElementConnection(_m.FileId, St7.tyBRICK, n, property, c);
        return n;
    }
    /// <summary>Iterate every brick in the model.</summary>
    public St7Enumerator<Brick> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<Brick>(Count, i => new Brick(m, i));
    }
}
/// <summary>Strongly-typed view onto one brick element.</summary>
public readonly struct Brick
{
    private readonly St7Model _m;
    public int Number { get; }
    internal Brick(St7Model m, int number) { _m = m; Number = number; }
    public int Property
    {
        get => St7Native.St7GetElementProperty(_m.FileId, St7.tyBRICK, Number);
        set => St7Native.St7SetElementProperty(_m.FileId, St7.tyBRICK, Number, value);
    }
    public int[] Connection
    {
        get
        {
            var c = new int[St7.kMaxElementNode];
            St7Native.St7GetElementConnection(_m.FileId, St7.tyBRICK, Number, c);
            int n = c[0];
            var r = new int[n];
            Array.Copy(c, 1, r, 0, n);
            return r;
        }
    }
    public int Group
    {
        get => St7Native.St7GetEntityGroup(_m.FileId, St7.tyBRICK, Number);
        set => St7Native.St7SetEntityGroup(_m.FileId, St7.tyBRICK, Number, value);
    }

    /// <summary>Apply a 3-component global pressure on the given brick face.</summary>
    public void SetGlobalPressure(int loadCase, int faceNum, bool project, Vector3 pressure)
        => St7Native.St7SetBrickGlobalPressure3(_m.FileId, Number, faceNum,
            St7Check.AsByte(project), loadCase, pressure.ToArray());
    /// <summary>Reads back the global pressure attribute. Returns (projectFlag, p).</summary>
    public (bool Project, Vector3 Pressure) GetGlobalPressure(int loadCase, int faceNum)
    {
        var d = new double[3];
        int pf = St7Native.St7GetBrickGlobalPressure3(_m.FileId, Number, faceNum, loadCase, d);
        return (pf != 0, Vector3.FromArray(d));
    }

    /// <summary>Heat-source attribute (St7SetBrickHeatSource1).</summary>
    public void SetHeatSource(int loadCase, double q)
        => St7Native.St7SetBrickHeatSource1(_m.FileId, Number, loadCase, new[] { q });
    public double GetHeatSource(int loadCase)
    {
        var d = new double[1]; St7Native.St7GetBrickHeatSource1(_m.FileId, Number, loadCase, d);
        return d[0];
    }

    /// <summary>Geometric centroid of the brick (faceEdge=0 = the whole element).</summary>
    public Vector3 Centroid
    {
        get { var d = new double[3]; St7Native.St7GetElementCentroid(_m.FileId, St7.tyBRICK, Number, 0, d); return Vector3.FromArray(d); }
    }

    /// <summary>Non-structural mass on a brick face (6 doubles per attribute id):
    /// [0]=mass, [1]=dynamic factor, [2..5]=global XYZ offset.</summary>
    public void SetNonStructuralMass(int loadCase, int faceNum, int attributeId, double[] data)
        => St7Native.St7SetBrickNSMass5ID(_m.FileId, Number, faceNum, loadCase, attributeId, data);
    public double[] GetNonStructuralMass(int loadCase, int faceNum, int attributeId)
    {
        var d = new double[6];
        St7Native.St7GetBrickNSMass5ID(_m.FileId, Number, faceNum, loadCase, attributeId, d);
        return d;
    }

    /// <summary>Cavity-fluid layout ID assigned on a given brick face.</summary>
    public int GetCavityFluid(int faceNum) => St7Native.St7GetBrickCavityFluid(_m.FileId, Number, faceNum);
    public void SetCavityFluid(int faceNum, int cavityId)
        => St7Native.St7SetBrickCavityFluid(_m.FileId, Number, faceNum, cavityId);
}
