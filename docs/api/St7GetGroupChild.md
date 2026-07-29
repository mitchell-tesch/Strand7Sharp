# St7GetGroupChild

Returns the first child of the specified group. ChildID is -1 if the specified group has no children.

long St7GetGroupChild(long uID, long GroupID, long* ChildID)
Input Parameters
uID
Strand7 model file ID.
GroupID
The ID number of the specified parent group.
Output Parameters
ChildID
The ID number of the group child.
