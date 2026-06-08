# St7SetEntitySelectStateByProperty

Selects or deselects all entities of a given type based on the property number, link type or load path template
number.

long St7SetEntitySelectStateByProperty(long uID, long Entity, long PropertyNum,

bool Selected)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyBEAM, tyPLATE, tyBRICK, tyLINK, tyGEOMETRYEDGE, tyGEOMETRYCOEDGE, tyGEOMETRYFACE
or tyLOADPATH.

PropertyNum

For elements and geometric entities, the property number.

For links, one of the link types described in Link Types.

Strand7 API Manual

For Load Paths, the load path template number.

Selected

Either True or False.
