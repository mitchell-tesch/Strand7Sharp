# St7SetEntitySelectStateByGroup

Selects or deselects all entities of a given type in a given group.

long St7SetEntitySelectStateByGroup(long uID, long Entity, long GroupID,

bool Selected)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyBEAM, tyPLATE, tyBRICK, tyLINK, tyGEOMETRYEDGE, tyGEOMETRYCOEDGE, tyGEOMETRYFACE
or tyLOADPATH.

GroupID

Group ID.

Selected

Either True or False.
