# St7GetGroupByIndex

Returns the group name and ID number corresponding to the specified index.

long St7GetGroupByIndex(long uID, long Index, char* GName, long MaxStringLen,

long* GroupID)

Input Parameters

uID

Strand7 model file ID.

Index

The index of the specified group. The list of group indices is always contiguous, starting from 1.

MaxStringLen

The maximum number of characters allocated for GName.

Output Parameters

GName

String containing the name of the specified group.

GroupID

The ID number corresponding to the specified group. Group ID numbers are not required to be
contiguous.
