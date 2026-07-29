# St7GetBrickCavityFluid

Returns the cavity fluid layout assigned to a face of the specified brick.

long St7GetBrickCavityFluid(long uID, long BrickNum, long FaceNum,
long* CavityID)
Input Parameters
uID
Strand7 model file ID.
BrickNum
Brick number.
FaceNum
Local face number. See Brick Local Coordinates for additional information.
Output Parameters
CavityID
Cavity fluid layout ID.
