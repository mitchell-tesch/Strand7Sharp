# St7GetGeometryFaceGlobalPressure3S

Returns the components of face pressure applied to the specified geometry face surface in the global XYZ system.
See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetGeometryFaceGlobalPressure3S(long uID, long FaceNum, long Surface,

long CaseNum, long* ProjectFlag, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

FaceNum

Face number.

Surface

Plate surface that inherits the attribute; either psPlateMinusZ or psPlatePlusZ.

CaseNum

Load case number.

Output Parameters
ProjectFlag

One of ppNone, ppProjResultant or ppProjComponents.

Doubles[0..2]

A 3-element array containing the pressure components in the global XYZ system.
