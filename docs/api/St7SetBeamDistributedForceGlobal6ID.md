# St7SetBeamDistributedForceGlobal6ID

Assigns distributed load data for the specified beam element. The force is defined in the global XYZ system.

long St7SetBeamDistributedForceGlobal6ID(long uID, long BeamNum, long BeamDir,
long ProjectFlag, long CaseNum, long DLType, long ID, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BeamNum

Beam number.

BeamDir

Global XYZ direction; one of 1, 2 or 3.

ProjectFlag

bpNone or bpProjected.

CaseNum

Load case number.

DLType

One of dlConstant, dlLinear, dlTriangular, dlThreePoint0, dlThreePoint1 or dlTrapezoidal.

ID

Distributed load ID.

Beam Attributes – Set

Doubles[0..5]

A 6-element array describing the distributed load. See Beam Distributed Load Types for additional
information.
