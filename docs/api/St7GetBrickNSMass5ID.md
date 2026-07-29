# St7GetBrickNSMass5ID

Returns the non-structural mass assigned to the specified brick. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetBrickNSMass5ID(long uID, long BrickNum, long FaceNum, long CaseNum,
long ID, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BrickNum
Brick number.
FaceNum
Local face number. See Brick Local Coordinates for additional information.
CaseNum
Load case number.
ID
Non-structural mass ID.

Output Parameters
Doubles[0..5]
[0] – Non-structural mass for the specified brick face.
[1] – Dynamic factor for the specified brick face. This factor is used to scale the non-structural mass
when performing dynamic analyses.
[2..5] – A 3-element array describing the offset in the global XYZ system.
