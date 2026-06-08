# St7SetGeometryFaceGlobalPressure3S

Assigns components of face pressure to the specified geometry face surface in the global XYZ system.

long St7SetGeometryFaceGlobalPressure3S(long uID, long FaceNum, long Surface,

long ProjectFlag, long CaseNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

FaceNum

Face number.

Surface

Plate surface that inherits the attribute; either psPlateMinusZ or psPlatePlusZ.

ProjectFlag

One of ppNone, ppProjResultant or ppProjComponents.

CaseNum

Load case number.

Doubles[0..2]

A 3-element array containing the pressure components in the global XYZ system.
