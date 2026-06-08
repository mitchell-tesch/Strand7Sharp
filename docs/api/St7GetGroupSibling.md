# St7GetGroupSibling

Returns the next sibling of the specified group. SiblingID is -1 if the specified group has no subsequent siblings.

Strand7 API Manual

long St7GetGroupSibling(long uID, long GroupID, long* SiblingID)

Input Parameters

uID

Strand7 model file ID.

GroupID

The ID number of the specified group.

Output Parameters
SiblingID

The ID number of the group sibling.
