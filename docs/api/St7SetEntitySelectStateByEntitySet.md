# St7SetEntitySelectStateByEntitySet

Selects or deselects all entities of a given type in a given entity set.

long St7SetEntitySelectStateByEntitySet(long uID, long Entity, long SetNum,
bool Selected)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyNODE, tyBEAM, tyPLATE, tyBRICK, tyLINK, tyVERTEX, tyGEOMETRYEDGE,
tyGEOMETRYCOEDGE, tyGEOMETRYFACE or tyLOADPATH.
SetNum
Entity set number. Use zero to select or deselect entities contained in no entity set.
Selected
Either True or False.
