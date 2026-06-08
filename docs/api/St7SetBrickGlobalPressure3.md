# St7SetBrickGlobalPressure3

Assigns a constant pressure to the specified brick face.  The pressure is defined in the global XYZ system.

long St7SetBrickGlobalPressure3(long uID, long BrickNum, long FaceNum,

long ProjectFlag, long CaseNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BrickNum

Brick number.

FaceNum

Local face number. See Brick Local Coordinates for additional information.

ProjectFlag

One of ppNone, ppProjResultant or ppProjComponents.

CaseNum

Load case number.

Doubles[0..2]

A 3-element array containing the pressure components in the global XYZ system.
