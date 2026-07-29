# St7GetTotal

Returns the total number of entities of the specified entity type in a Strand7 model.

long St7GetTotal(long uID, long Entity, long* Total)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyNODE, tyBEAM, tyPLATE, tyBRICK, tyLINK, tyVERTEX, tyGEOMETRYEDGE,
tyGEOMETRYCOEDGE, tyGEOMETRYLOOP, tyGEOMETRYFACE or tyLOADPATH.
Output Parameters
Total
Number of entities in the model.
