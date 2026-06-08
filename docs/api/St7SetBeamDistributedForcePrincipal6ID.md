# St7SetBeamDistributedForcePrincipal6ID

Assigns distributed load data for the specified beam element. The force is defined in the principal axis system of
the beam.

long St7SetBeamDistributedForcePrincipal6ID(long uID, long BeamNum, long BeamDir,

long CaseNum, long DLType, long ID, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BeamNum

Beam number.

BeamDir

Principal or local axis direction.  Principal directions are denoted as 1, 2 or 3; local directions are
denoted as either 4 (local x) or 5 (local y); see Beam Local Coordinates.

CaseNum

Load case number.

DLType

One of dlConstant, dlLinear, dlTriangular, dlThreePoint0, dlThreePoint1 or dlTrapezoidal.

ID

Distributed load ID.

Doubles[0..5]

A 6-element array describing the distributed load. See Beam Distributed Load Types for additional
information.
