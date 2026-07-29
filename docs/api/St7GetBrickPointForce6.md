# St7GetBrickPointForce6

Returns the point force assigned to the specified brick face. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetBrickPointForce6(long uID, long BrickNum, long FaceNum, long CaseNum,
long Position, long ID, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BrickNum
Brick number.
FaceNum
Local face number. See Brick Local Coordinates for additional information.
CaseNum
Load case number.
Position
Position identifier; either axUCS or axLocal.
ID
Point force ID.
Output Parameters
Doubles[0..5]
[0..2] – Components of the applied force in the global XYZ system.
Where Position is axUCS:
[3..5] – The position of the applied force in global XYZ coordinates.
Where Position is axLocal:
[3..4] – The uv position of the applied force in the local element coordinate system.
