# St7ShowMarker

Shows a previously created marker.

long St7ShowMarker(long uID, long Entity, long EntityNum, long FaceNum)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyNODE, tyBEAM, tyPLATE, tyBRICK, tyLINK, tyVERTEX, tyGEOMETRYFACE or tyLOADPATH.
EntityNum
Entity number.
FaceNum
Brick element face number (1-6). For marker type mtEntityHighlight, 0 is also valid and indicates the
marker applies to the whole brick.
