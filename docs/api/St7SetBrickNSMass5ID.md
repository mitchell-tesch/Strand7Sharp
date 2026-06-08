# St7SetBrickNSMass5ID

Assigns a non-structural mass to the specified brick.

long St7SetBrickNSMass5ID(long uID, long BrickNum, long FaceNum, long CaseNum,

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

Doubles[0..5]

[0] – Non-structural mass for the specified brick face.

[1] – Dynamic factor for the specified brick face. This factor is used to scale the non-structural mass
when performing dynamic analyses.

[2..5] – A 3-element array describing the offset in the global XYZ system.
