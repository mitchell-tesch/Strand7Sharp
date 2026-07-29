# St7GetBrickFaceAxisSystemInitial

Returns the brick face axis system for the specified brick face based on the initial node coordinates. See Brick
Local Coordinates for additional information.

long St7GetBrickFaceAxisSystemInitial(long uID, long BrickNum, long FaceNum,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BrickNum
Brick number.
FaceNum
Local face number. See Brick Local Coordinates for additional information.
Output Parameters
Doubles[0..8]
[0..2] – A unit vector in the global XYZ system, defining the local x direction of the face.
[3..5] – A unit vector in the global XYZ system, defining the local y direction of the face.
[6..8] – A unit vector in the global XYZ system, defining the local z direction of the face; note that this
is directed out of the median plane of the face.
