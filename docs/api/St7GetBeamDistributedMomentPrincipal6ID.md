# St7GetBeamDistributedMomentPrincipal6ID

Returns distributed moment data assigned to the specified beam element. The moment is applied according to
the principal axis system of the beam. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetBeamDistributedMomentPrincipal6ID(long uID, long BeamNum,

long BeamDir, long CaseNum, long ID, long* DLType, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Beam Attributes – Get

BeamNum

Beam number.

BeamDir

Principal axis direction; one of 1, 2 or 3; see Beam Local Coordinates.

CaseNum

Load case number.

ID

Distributed moment ID.

Output Parameters

DLType

One of dlConstant, dlLinear, dlTriangular, dlThreePoint0, dlThreePoint1 or dlTrapezoidal.

Doubles[0..5]

A 6-element array describing the distributed moment. See Beam Distributed Load Types for additional
information.
