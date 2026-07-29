# St7SetBrickShear2

Assigns a shear stress to the specified brick face. The shear stress acts in the plane of the face and is constant over
the surface.

long St7SetBrickShear2(long uID, long BrickNum, long FaceNum, long CaseNum,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BrickNum
Brick number.

FaceNum
Local face number. See Brick Local Coordinates for additional information.
CaseNum
Load case number.
Doubles[0..1]
A 2-element array describing the shear stress components in the local face xy axis system. See Brick
Local Coordinates for details.
