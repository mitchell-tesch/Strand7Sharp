# St7SetAllEntitySelectState

Selects or deselects all entities of a given type.

long St7SetAllEntitySelectState(long uID, long Entity, bool Selected)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyNODE, tyBEAM, tyPLATE, tyBRICK, tyLINK, tyVERTEX, tyGEOMETRYEDGE,
tyGEOMETRYCOEDGE, tyGEOMETRYLOOP, tyGEOMETRYFACE or tyLOADPATH.
Selected
Either True or False.
