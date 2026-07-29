# St7GetBeamNSMass10ID

Returns non-structural mass assigned to the specified beam element. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetBeamNSMass10ID(long uID, long BeamNum, long CaseNum, long ID,
long* DLType, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BeamNum
Beam number.
CaseNum
Load case number.
ID
Mass distribution ID.
Output Parameters
DLType
One of dlConstant, dlLinear, dlTriangular, dlThreePoint0, dlThreePoint1 or dlTrapezoidal.
Doubles[0..9]
[0..5] – The distributed mass parameters. See Beam Distributed Load Types for additional
information.
[6] – Dynamic factor.
[7..9] – Offset vector in the global XYZ system.
