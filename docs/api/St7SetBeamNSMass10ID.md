# St7SetBeamNSMass10ID

Assigns non-structural mass for the specified beam.

long St7SetBeamNSMass10ID(long uID, long BeamNum, long CaseNum, long DLType,

long ID, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BeamNum

Beam number.

CaseNum

Load case number.

DLType

One of dlConstant, dlLinear, dlTriangular, dlThreePoint0, dlThreePoint1 or dlTrapezoidal.

ID

Mass distribution ID.

Doubles[0..9]

[0..5] – The distributed mass parameters. See Beam Distributed Load Types for additional
information.

[6] – Dynamic factor.

[7..9] – Offset vector in the global XYZ system.
