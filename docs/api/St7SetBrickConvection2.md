# St7SetBrickConvection2

Assigns the thermal convection coefficient and ambient temperature for the specified brick face.

long St7SetBrickConvection2(long uID, long BrickNum, long FaceNum, long CaseNum,
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
[0] – Convection coefficient.
[1] – Ambient temperature.
