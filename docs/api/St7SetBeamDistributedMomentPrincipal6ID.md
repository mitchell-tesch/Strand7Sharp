# St7SetBeamDistributedMomentPrincipal6ID

Assigns distributed moment data for the specified beam element. The moment is defined in the principal axis
system of the beam.

long St7SetBeamDistributedMomentPrincipal6ID(long uID, long BeamNum,
long BeamDir, long CaseNum, long DLType, long ID, double* Doubles)
Input Parameters
uID
Strand7 model file ID.

BeamNum
Beam number.
BeamDir
Principal axis direction; one of 1, 2 or 3; see Beam Local Coordinates.
CaseNum
Load case number.
DLType
One of dlConstant, dlLinear, dlTriangular, dlThreePoint0, dlThreePoint1 or dlTrapezoidal.
ID
Distributed moment ID.
Doubles[0..5]
A 6-element array describing the distributed moment. See Beam Distributed Load Types for additional
information.
