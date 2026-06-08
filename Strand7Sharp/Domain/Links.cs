using St7API;
namespace Strand7Sharp;
/// <summary>Indexed access to the model's link elements (rigid, MPC, etc.).</summary>
public readonly struct LinkCollection
{
    private readonly St7Model _m;
    internal LinkCollection(St7Model m) => _m = m;
    public int Count => St7Native.St7GetTotal(_m.FileId, St7.tyLINK);
    public Link this[int number] => new(_m, number);

    /// <summary>Create a pinned link between two nodes. Returns its 1-based number.</summary>
    public int AddPinned(int node1, int node2)
    {
        int n = Count + 1;
        St7Native.St7SetPinnedLink(_m.FileId, n, new[] { node1, node2 });
        return n;
    }
    /// <summary>Create a rigid link spanning the given node list. Returns the new link number.</summary>
    public int AddRigid(int ucsId, int plane, params int[] nodes)
    {
        int n = Count + 1;
        St7Native.St7SetRigidLink(_m.FileId, n, ucsId, plane, nodes);
        return n;
    }
    /// <summary>Create a master/slave link with the given UCS, node connection and 6 DOF mask.</summary>
    public int AddMasterSlave(int ucsId, int[] connection, int[] dofMask)
    {
        int n = Count + 1;
        St7Native.St7SetMasterSlaveLink(_m.FileId, n, ucsId, connection, dofMask);
        return n;
    }
    /// <summary>Create a coupling link (translational/rotational/both).</summary>
    public int AddCoupling(int couple, int[] connection)
    {
        int n = Count + 1;
        St7Native.St7SetCouplingLink(_m.FileId, n, couple, connection);
        return n;
    }
    /// <summary>Iterate every link in the model.</summary>
    public St7Enumerator<Link> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<Link>(Count, i => new Link(m, i));
    }
}
/// <summary>Strongly-typed view onto one link element.</summary>
public readonly struct Link
{
    private readonly St7Model _m;
    public int Number { get; }
    internal Link(St7Model m, int number) { _m = m; Number = number; }

    /// <summary>The kind of link (rigid, MPC, pinned, …).</summary>
    public LinkType Type => (LinkType)St7Native.St7GetLinkType(_m.FileId, Number);

    public int Group
    {
        get => St7Native.St7GetEntityGroup(_m.FileId, St7.tyLINK, Number);
        set => St7Native.St7SetEntityGroup(_m.FileId, St7.tyLINK, Number, value);
    }

    /// <summary>Read the node list of a pinned link.</summary>
    public int[] GetPinnedConnection()
    {
        var c = new int[2];
        St7Native.St7GetPinnedLink(_m.FileId, Number, c);
        return c;
    }
}
