# St7GetEntitySetEntityState

Checks whether or not an entity is included in an entity set.

long St7GetEntitySetEntityState(long uID, long Entity, long EntityNum,

long SetNum, bool* Included)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyNODE, tyBEAM, tyPLATE, tyBRICK, tyLINK, tyLOADPATH, tyVERTEX, tyGEOMETRYFACE or
tyGEOMETRYCOEDGE.

EntityNum

Entity number.

Entity Sets

SetNum

The number of the entity set.

Included

True if the entity is included in the entity set.

Strand7 API Manual

Units
