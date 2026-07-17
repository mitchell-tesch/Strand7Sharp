using St7API;
namespace Strand7Sharp;
/// <summary>Groups (display / visibility tree) defined on the model.</summary>
public readonly struct GroupCollection
{
    private readonly St7Model _m;
    internal GroupCollection(St7Model m) => _m = m;
    /// <summary>Number of groups defined.</summary>
    public int Count => St7Native.St7GetNumGroups(_m.FileId);
    /// <summary>Look up a group by 1-based index. Returns (name, groupId) as reported by St7GetGroupByIndex.</summary>
    public (string Name, int GroupID) GetByIndex(int index)
        => St7Native.St7GetGroupByIndex(_m.FileId, index);
    /// <summary>Get / set the name of a group by its ID.</summary>
    public string GetName(int groupId) => St7Native.St7GetGroupIDName(_m.FileId, groupId);
    public void SetName(int groupId, string name) => St7Native.St7SetGroupIDName(_m.FileId, groupId, name);
    /// <summary>Add a new child group under <paramref name="parentId"/>; returns the new group ID.</summary>
    public int AddChild(int parentId, string name) => St7Native.St7NewChildGroup(_m.FileId, parentId, name);
    public void Delete(int groupId) => St7Native.St7DeleteGroup(_m.FileId, groupId);

    /// <summary>
    /// Attempts to delete a group. Returns <c>true</c> on success, <c>false</c>
    /// when Strand7 refuses because the group id no longer exists (e.g. it was
    /// cascade-deleted along with a parent). Any other error still throws
    /// <see cref="St7Exception"/>.
    /// </summary>
    public bool TryDelete(int groupId) => TryDelete(groupId, out _);

    /// <summary>
    /// Attempts to delete a group. Returns <c>true</c> on success. On failure
    /// returns <c>false</c> and reports the Strand7 error code via
    /// <paramref name="errorCode"/> — <see cref="St7ErrorCode.GroupIdDoesNotExist"/>
    /// is treated as a soft failure; any other code is re-thrown as
    /// <see cref="St7Exception"/>.
    /// </summary>
    public bool TryDelete(int groupId, out St7ErrorCode errorCode)
    {
        try
        {
            St7Native.St7DeleteGroup(_m.FileId, groupId);
            errorCode = St7ErrorCode.None;
            return true;
        }
        catch (St7Exception ex) when (ex.Code == St7ErrorCode.GroupIdDoesNotExist)
        {
            errorCode = ex.Code;
            return false;
        }
    }

    /// <summary>The root (default) group id, as reported by <c>St7GetDefaultGroupID</c>.</summary>
    public int RootId => St7Native.St7GetDefaultGroupID(_m.FileId);

    public void Show(int groupId) => St7Native.St7ShowGroup(_m.FileId, groupId);
    public void Hide(int groupId) => St7Native.St7HideGroup(_m.FileId, groupId);
    /// <summary>Whether the group is currently visible.</summary>
    public bool GetVisible(int groupId) => St7Native.St7GetGroupVisibility(_m.FileId, groupId) != 0;

    /// <summary>Parent group ID (0 for the root group).</summary>
    public int GetParent(int groupId) => St7Native.St7GetGroupParent(_m.FileId, groupId);
    /// <summary>First-child group ID under <paramref name="groupId"/> (0 if none).</summary>
    public int GetChild(int groupId) => St7Native.St7GetGroupChild(_m.FileId, groupId);
    /// <summary>Next-sibling group ID (0 if none).</summary>
    public int GetSibling(int groupId) => St7Native.St7GetGroupSibling(_m.FileId, groupId);

    /// <summary>Iterate (name, id) for every group in the model.</summary>
    public St7Enumerator<(string Name, int GroupID)> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<(string, int)>(Count, i => St7Native.St7GetGroupByIndex(m.FileId, i));
    }
}
