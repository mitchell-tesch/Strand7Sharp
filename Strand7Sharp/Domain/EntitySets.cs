using St7API;
namespace Strand7Sharp;
/// <summary>Saved entity sets (named selections).</summary>
public readonly struct EntitySetCollection
{
    private readonly St7Model _m;
    internal EntitySetCollection(St7Model m) => _m = m;
    /// <summary>Total number of entity sets currently defined.</summary>
    public int Count => St7Native.St7GetNumEntitySets(_m.FileId);
    /// <summary>
    /// Creates a new (empty) entity set and returns its 1-based number.
    /// Per St7NewEntitySet, the new set is appended, so its index is the
    /// post-create <see cref="Count"/>.
    /// </summary>
    public int Add(string name)
    {
        St7Native.St7NewEntitySet(_m.FileId, name);
        return Count;
    }
    public void Delete(int setNum) => St7Native.St7DeleteEntitySet(_m.FileId, setNum);
    public string GetName(int setNum) => St7Native.St7GetEntitySetName(_m.FileId, setNum);
    public void SetName(int setNum, string name) => St7Native.St7SetEntitySetName(_m.FileId, setNum, name);
    /// <summary>Whether the given entity is included in this set.</summary>
    public bool Contains(int setNum, EntityType entity, int entityNum)
        => St7Native.St7GetEntitySetEntityState(_m.FileId, (int)entity, entityNum, setNum) != 0;
    public void Show(int setNum) => St7Native.St7ShowEntitySet(_m.FileId, setNum);
    public void Hide(int setNum) => St7Native.St7HideEntitySet(_m.FileId, setNum);
    public bool GetVisible(int setNum) => St7Native.St7GetEntitySetVisibility(_m.FileId, setNum) != 0;
    /// <summary>Append all currently-selected entities of the given type to the set.</summary>
    public void AddSelected(int setNum, EntityType entity)
        => St7Native.St7AddSelectedToEntitySet(_m.FileId, (int)entity, setNum);

    /// <summary>Iterate every entity set (1..Count).</summary>
    public St7Enumerator<int> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<int>(Count, i => i);
    }
}
