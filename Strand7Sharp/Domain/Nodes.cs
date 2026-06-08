using System;
using St7API;
namespace Strand7Sharp;
/// <summary>Indexed access to the model's nodes (1-based).</summary>
public readonly struct NodeCollection
{
    private readonly St7Model _m;
    internal NodeCollection(St7Model m) => _m = m;
    /// <summary>Total number of nodes (uses St7GetTotal(tyNODE)).</summary>
    public int Count => St7Native.St7GetTotal(_m.FileId, St7.tyNODE);
    /// <summary>Returns a lightweight handle for the node with the given 1-based number.</summary>
    public Node this[int number] => new(_m, number);
    /// <summary>Creates a new node at the given coordinates and returns its number.</summary>
    public int Add(double x, double y, double z)
    {
        int n = St7Native.St7GetTotal(_m.FileId, St7.tyNODE) + 1;
        St7Native.St7SetNodeXYZ(_m.FileId, n, new[] { x, y, z });
        return n;
    }
    /// <summary>Creates a new node at the given coordinates and returns its number.</summary>
    public int Add(Vector3 xyz) => Add(xyz.X, xyz.Y, xyz.Z);
    /// <summary>Iterate every node in the model (1..Count).</summary>
    public St7Enumerator<Node> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<Node>(Count, i => new Node(m, i));
    }
}
/// <summary>Strongly-typed view onto one node. Cheap value-type (just a (model, id) pair).</summary>
public readonly struct Node
{
    private readonly St7Model _m;
    /// <summary>1-based Strand7 node number.</summary>
    public int Number { get; }
    internal Node(St7Model m, int number) { _m = m; Number = number; }
    /// <summary>Get/set the Cartesian coordinates of the node.</summary>
    public Vector3 XYZ
    {
        get
        {
            var xyz = new double[3];
            St7Native.St7GetNodeXYZ(_m.FileId, Number, xyz);
            return Vector3.FromArray(xyz);
        }
        set => St7Native.St7SetNodeXYZ(_m.FileId, Number, value.ToArray());
    }
    /// <summary>User-defined ID label for the node (St7SetNodeID).</summary>
    public int Id
    {
        get => St7Native.St7GetNodeID(_m.FileId, Number);
        set => St7Native.St7SetNodeID(_m.FileId, Number, value);
    }
    /// <summary>Group this node belongs to.</summary>
    public int Group
    {
        get => St7Native.St7GetEntityGroup(_m.FileId, St7.tyNODE, Number);
        set => St7Native.St7SetEntityGroup(_m.FileId, St7.tyNODE, Number, value);
    }
    /// <summary>Get the node coordinates expressed in the given UCS.</summary>
    public Vector3 GetInUCS(int ucsId)
    {
        var xyz = new double[3];
        St7Native.St7GetNodeUCS(_m.FileId, Number, ucsId, xyz);
        return Vector3.FromArray(xyz);
    }
    /// <summary>Set the node coordinates as a (UCS, x, y, z) triple.</summary>
    public void SetInUCS(int ucsId, Vector3 xyz)
        => St7Native.St7SetNodeUCS(_m.FileId, Number, ucsId, xyz.ToArray());

    // --- Concentrated loads ---
    /// <summary>Applies a 3-component nodal force in the global system for the given load case.</summary>
    public void SetForce(int loadCase, double fx, double fy, double fz)
        => St7Native.St7SetNodeForce3(_m.FileId, Number, loadCase, new[] { fx, fy, fz });
    public void SetForce(int loadCase, Vector3 force)
        => St7Native.St7SetNodeForce3(_m.FileId, Number, loadCase, force.ToArray());
    /// <summary>Applies a 3-component nodal moment for the given load case.</summary>
    public void SetMoment(int loadCase, double mx, double my, double mz)
        => St7Native.St7SetNodeMoment3(_m.FileId, Number, loadCase, new[] { mx, my, mz });
    public void SetMoment(int loadCase, Vector3 moment)
        => St7Native.St7SetNodeMoment3(_m.FileId, Number, loadCase, moment.ToArray());
    /// <summary>Reads the applied nodal force for the given load case.</summary>
    public Vector3 GetForce(int loadCase)
    {
        var d = new double[3]; St7Native.St7GetNodeForce3(_m.FileId, Number, loadCase, d);
        return Vector3.FromArray(d);
    }
    /// <summary>Reads the applied nodal moment for the given load case.</summary>
    public Vector3 GetMoment(int loadCase)
    {
        var d = new double[3]; St7Native.St7GetNodeMoment3(_m.FileId, Number, loadCase, d);
        return Vector3.FromArray(d);
    }

    // --- Restraints ---
    /// <summary>
    /// Sets the 6-DOF restraint status and prescribed displacement values at the node
    /// for the given freedom case (uses St7SetNodeRestraint6).
    /// </summary>
    public void SetRestraint(int freedomCase, int ucsId, int[] status, double[] values)
    {
        if (status.Length != 6) throw new ArgumentException("status must have length 6.", nameof(status));
        if (values.Length != 6) throw new ArgumentException("values must have length 6.", nameof(values));
        St7Native.St7SetNodeRestraint6(_m.FileId, Number, freedomCase, ucsId, status, values);
    }
    public void SetRestraint(int freedomCase, int ucsId, DofStatus status, DofValues values)
        => St7Native.St7SetNodeRestraint6(_m.FileId, Number, freedomCase, ucsId, status.ToArray(), values.ToArray());
    /// <summary>Fully fix all 6 DOFs at the node for the given freedom case.</summary>
    public void Fix(int freedomCase, int ucsId = 1)
        => SetRestraint(freedomCase, ucsId, DofStatus.Fixed, DofValues.Zero);

    // --- Springs / dampers ---
    /// <summary>Translational spring stiffness on the node for the load case.</summary>
    public (int UcsId, Vector3 K) GetTranslationalSpringStiffness(int loadCase)
    {
        var d = new double[3];
        int ucs = St7Native.St7GetNodeKTranslation3F(_m.FileId, Number, loadCase, d);
        return (ucs, Vector3.FromArray(d));
    }
    public void SetTranslationalSpringStiffness(int loadCase, int ucsId, Vector3 k)
        => St7Native.St7SetNodeKTranslation3F(_m.FileId, Number, loadCase, ucsId, k.ToArray());
    public (int UcsId, Vector3 K) GetRotationalSpringStiffness(int loadCase)
    {
        var d = new double[3];
        int ucs = St7Native.St7GetNodeKRotation3F(_m.FileId, Number, loadCase, d);
        return (ucs, Vector3.FromArray(d));
    }
    public void SetRotationalSpringStiffness(int loadCase, int ucsId, Vector3 k)
        => St7Native.St7SetNodeKRotation3F(_m.FileId, Number, loadCase, ucsId, k.ToArray());

    // --- Masses ---
    /// <summary>Lumped translational mass (single scalar).</summary>
    public double TranslationalMass { set => St7Native.St7SetNodeTMass1(_m.FileId, Number, value); }
    public Vector3 TranslationalMass3
    {
        get { var d = new double[3]; St7Native.St7GetNodeTMass3(_m.FileId, Number, d); return Vector3.FromArray(d); }
        set => St7Native.St7SetNodeTMass3(_m.FileId, Number, value.ToArray());
    }
    public (int UcsId, Vector3 Mass) GetRotationalMass()
    {
        var d = new double[3]; int ucs = St7Native.St7GetNodeRMass3(_m.FileId, Number, d);
        return (ucs, Vector3.FromArray(d));
    }
    public void SetRotationalMass(int ucsId, Vector3 mass)
        => St7Native.St7SetNodeRMass3(_m.FileId, Number, ucsId, mass.ToArray());

    // --- Temperature ---
    /// <summary>Temperature attribute for the load case.</summary>
    public void SetTemperature(int loadCase, double temperature)
        => St7Native.St7SetNodeTemperature1(_m.FileId, Number, loadCase, new[] { temperature });
    public double GetTemperature(int loadCase)
    {
        var d = new double[1]; St7Native.St7GetNodeTemperature1(_m.FileId, Number, loadCase, d);
        return d[0];
    }
    public NodeTemperatureType GetTemperatureType(int loadCase)
        => (NodeTemperatureType)St7Native.St7GetNodeTemperatureType1(_m.FileId, Number, loadCase);
    public void SetTemperatureType(int loadCase, NodeTemperatureType type)
        => St7Native.St7SetNodeTemperatureType1(_m.FileId, Number, loadCase, (int)type);
    public int GetTemperatureTable(int loadCase)
        => St7Native.St7GetNodeTemperatureTable(_m.FileId, Number, loadCase);
    public void SetTemperatureTable(int loadCase, int tableId)
        => St7Native.St7SetNodeTemperatureTable(_m.FileId, Number, loadCase, tableId);

    // --- Heat source ---
    public void SetHeatSource(int loadCase, double q)
        => St7Native.St7SetNodeHeatSource1(_m.FileId, Number, loadCase, new[] { q });
    public double GetHeatSource(int loadCase)
    {
        var d = new double[1]; St7Native.St7GetNodeHeatSource1(_m.FileId, Number, loadCase, d);
        return d[0];
    }

    // --- Initial conditions ---
    public void SetInitialVelocity(int loadCase, Vector3 v)
        => St7Native.St7SetNodeInitialVelocity3(_m.FileId, Number, loadCase, v.ToArray());
    public Vector3 GetInitialVelocity(int loadCase)
    {
        var d = new double[3]; St7Native.St7GetNodeInitialVelocity3(_m.FileId, Number, loadCase, d);
        return Vector3.FromArray(d);
    }

    // --- Non-structural mass (5 doubles per attribute id) ---
    public void SetNonStructuralMass(int loadCase, int attributeId, double[] data)
        => St7Native.St7SetNodeNSMass5ID(_m.FileId, Number, loadCase, attributeId, data);
    public double[] GetNonStructuralMass(int loadCase, int attributeId)
    {
        var d = new double[5];
        St7Native.St7GetNodeNSMass5ID(_m.FileId, Number, loadCase, attributeId, d);
        return d;
    }

    // --- Adjacency: which elements touch this node? ---
    /// <summary>Number of elements of <paramref name="adjacencyIndex"/> type attached to the node.</summary>
    public int NumElementsAttached(int adjacencyIndex = 0)
        => St7Native.St7GetNumElementsAtNode(_m.FileId, adjacencyIndex, Number);
    /// <summary>Returns the entity numbers and entity types touching this node.</summary>
    public (int[] EntityNums, int[] EntityTypes) GetElementsAttached(int adjacencyIndex = 0)
    {
        int n = NumElementsAttached(adjacencyIndex);
        var nums = new int[n]; var types = new int[n];
        if (n > 0) St7Native.St7GetElementsAtNode(_m.FileId, adjacencyIndex, Number, nums, types, n);
        return (nums, types);
    }
}
