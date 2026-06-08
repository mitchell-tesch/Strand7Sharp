# St7SetBrickFlux1

Assigns a heat flux to the specified brick face.

long St7SetBrickFlux1(long uID, long BrickNum, long FaceNum, long CaseNum,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BrickNum

Brick number.

FaceNum

Local face number. See Brick Local Coordinates for additional information.

CaseNum

Load case number.

Doubles[0]

The heat flux through the brick face.
