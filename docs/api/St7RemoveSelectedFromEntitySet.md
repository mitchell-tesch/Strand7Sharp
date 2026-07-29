# St7RemoveSelectedFromEntitySet

Removes the selected entities from an entity set.

long St7RemoveSelectedFromEntitySet(long uID, long Entity, long SetNum)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyNODE, tyBEAM, tyPLATE, tyBRICK, tyLINK, tyLOADPATH, tyVERTEX, tyGEOMETRYFACE or
tyGEOMETRYCOEDGE.
SetNum
The number of the entity set.
Dependencies
Keep Selected
Assigned using St7SetKeepSelect.
