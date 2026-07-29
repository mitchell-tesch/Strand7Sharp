# St7GetBeamDistributedForceGlobal6ID

Returns distributed load data assigned to the specified beam element. The force components are defined in the
global XYZ system. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetBeamDistributedForceGlobal6ID(long uID, long BeamNum, long BeamDir,
long CaseNum, long ID, long* ProjectFlag, long* DLType, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BeamNum
Beam number.
BeamDir
Global XYZ direction; one of 1, 2 or 3.
CaseNum
Load case number.
ID
Distributed load ID.
Output Parameters
ProjectFlag
bpNone or bpProjected.

DLType
One of dlConstant, dlLinear, dlTriangular, dlThreePoint0, dlThreePoint1 or dlTrapezoidal.
Doubles[0..5]
A 6-element array describing the distributed load. See Beam Distributed Load Types for additional
information.
