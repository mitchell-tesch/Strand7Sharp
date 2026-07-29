# St7GetGroupParent

Returns the parent of the specified group. ParentID is -1 if the specified group is the root group.

long St7GetGroupParent(long uID, long GroupID, long* ParentID)
Input Parameters
uID
Strand7 model file ID.
GroupID
The ID number of the specified child group.
Output Parameters
ParentID
The ID number of the parent group.
