# St7SetBrickNormalPressure1

Assigns a pressure to the specified brick face. The pressure acts into the element, normal to the plane of the face
and is constant over the surface.

long St7SetBrickNormalPressure1(long uID, long BrickNum, long FaceNum,
long CaseNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BrickNum
Brick number.
FaceNum
Local face number. See Brick Local Coordinates for additional information.

CaseNum
Load case number.
Doubles[0]
Normal pressure.
