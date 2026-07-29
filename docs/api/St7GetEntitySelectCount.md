# St7GetEntitySelectCount

Returns the number entities of the specified type that are selected.

long St7GetEntitySelectCount(long uID, long Entity, long* NumSelected)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyNODE, tyBEAM, tyPLATE, tyBRICK, tyLINK, tyVERTEX, tyGEOMETRYEDGE,
tyGEOMETRYCOEDGE, tyGEOMETRYFACE or tyLOADPATH.
Output Parameters
NumSelected
Selected count.

Model Window
