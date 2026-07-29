# St7GetBrickGlobalPressure3

Returns the pressure assigned to the specified brick face. The pressure is constant and is defined in the global XYZ
system. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetBrickGlobalPressure3(long uID, long BrickNum, long FaceNum,
long CaseNum, long* ProjectFlag, double* Doubles)
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
ProjectFlag
One of ppNone, ppProjResultant or ppProjComponents.
Doubles[0..2]
A 3-element array containing the pressure components in the global XYZ system.
