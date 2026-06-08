using St7API;
namespace Strand7Sharp;
/// <summary>Read and mutate the model's selection state.</summary>
public readonly struct SelectionApi
{
    private readonly St7Model _m;
    internal SelectionApi(St7Model m) => _m = m;
    /// <summary>Whether the given entity (node/beam/etc.) is currently selected.</summary>
    public bool IsSelected(EntityType entity, int entityNum, int endEdgeFace = 0)
        => St7Native.St7GetEntitySelectState(_m.FileId, (int)entity, entityNum, endEdgeFace) != 0;
    /// <summary>Get the raw select-state code for the entity (see <see cref="SelectState"/>).</summary>
    public SelectState GetState(EntityType entity, int entityNum, int endEdgeFace = 0)
        => (SelectState)St7Native.St7GetEntitySelectState(_m.FileId, (int)entity, entityNum, endEdgeFace);
    /// <summary>Set the select-state of the entity.</summary>
    public void SetState(EntityType entity, int entityNum, SelectState state, int endEdgeFace = 0)
        => St7Native.St7SetEntitySelectState(_m.FileId, (int)entity, entityNum, endEdgeFace, (byte)state);
    /// <summary>Select the entity.</summary>
    public void Select(EntityType entity, int entityNum, int endEdgeFace = 0)
        => SetState(entity, entityNum, SelectState.Selected, endEdgeFace);
    /// <summary>Unselect the entity.</summary>
    public void Unselect(EntityType entity, int entityNum, int endEdgeFace = 0)
        => SetState(entity, entityNum, SelectState.Unselected, endEdgeFace);
    /// <summary>Select all entities of <paramref name="entity"/> belonging to the group.</summary>
    public void SelectGroup(EntityType entity, int groupId)
        => St7Native.St7SetEntitySelectStateByGroup(_m.FileId, (int)entity, groupId, (byte)SelectState.Selected);
    public void UnselectGroup(EntityType entity, int groupId)
        => St7Native.St7SetEntitySelectStateByGroup(_m.FileId, (int)entity, groupId, (byte)SelectState.Unselected);
    /// <summary>Select all entities of the given type (St7SetAllEntitySelectState).</summary>
    public void SelectAll(EntityType entity)
        => St7Native.St7SetAllEntitySelectState(_m.FileId, (int)entity, (byte)SelectState.Selected);
    /// <summary>Unselect all entities of the given type.</summary>
    public void UnselectAll(EntityType entity)
        => St7Native.St7SetAllEntitySelectState(_m.FileId, (int)entity, (byte)SelectState.Unselected);
    /// <summary>Selects all entities of <paramref name="entity"/> with the given property number.</summary>
    public void SelectByProperty(EntityType entity, int propertyNum)
        => St7Native.St7SetEntitySelectStateByProperty(_m.FileId, (int)entity, propertyNum, (byte)SelectState.Selected);
    public void UnselectByProperty(EntityType entity, int propertyNum)
        => St7Native.St7SetEntitySelectStateByProperty(_m.FileId, (int)entity, propertyNum, (byte)SelectState.Unselected);
    /// <summary>Selects all entities in the named entity set.</summary>
    public void SelectEntitySet(EntityType entity, int setNum)
        => St7Native.St7SetEntitySelectStateByEntitySet(_m.FileId, (int)entity, setNum, (byte)SelectState.Selected);
    public void UnselectEntitySet(EntityType entity, int setNum)
        => St7Native.St7SetEntitySelectStateByEntitySet(_m.FileId, (int)entity, setNum, (byte)SelectState.Unselected);
    /// <summary>Number of entities of the given type currently selected.</summary>
    public int Count(EntityType entity)
        => St7Native.St7GetEntitySelectCount(_m.FileId, (int)entity);
}

