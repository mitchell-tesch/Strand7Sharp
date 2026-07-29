# St7SetEntitySelectState

Sets the selected state of the specified entity.

long St7SetEntitySelectState(long uID, long Entity, long EntityNum,
long EndEdgeFace, bool Selected)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyNODE, tyBEAM, tyPLATE, tyBRICK, tyLINK, tyVERTEX, tyGEOMETRYEDGE,
tyGEOMETRYCOEDGE, tyGEOMETRYLOOP, tyGEOMETRYFACE or tyLOADPATH.
EntityNum
Entity number.
EndEdgeFace
Local entity number; either 1 or 2 for tyBEAM; one of 1, 2, 3 or 4 for tyPLATE; or one of 1, 2, 3, 4, 5 or 6
for tyBRICK. Use 0 to select tyNODE or to select an entire tyBEAM, tyPLATE or tyBRICK.
Selected
Either True or False.
