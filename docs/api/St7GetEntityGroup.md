# St7GetEntityGroup

Returns the group number assigned to the specified entity.

long St7GetEntityGroup(long uID, long Entity, long EntityNum, long* GroupID)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyBEAM, tyPLATE, tyBRICK, tyLINK, tyGEOMETRYFACE or tyLOADPATH.

EntityNum

Entity number.

Output Parameters

GroupID

Group ID.
