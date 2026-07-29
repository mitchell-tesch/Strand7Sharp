# St7GetBrickFlux1

Returns the heat flux assigned to the specified brick face. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetBrickFlux1(long uID, long BrickNum, long FaceNum, long CaseNum,
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

Output Parameters
Doubles[0]
The heat flux through the brick face.
