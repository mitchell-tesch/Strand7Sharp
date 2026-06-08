# St7SetGeometryFaceConvection2

Assigns the thermal convection coefficient and ambient temperature for the specified geometry face.

long St7SetGeometryFaceConvection2(long uID, long FaceNum, long CaseNum,

long Surface, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

FaceNum

Face number.

CaseNum

Load case number.

Surface

Local plate surface; either psPlateMinusZ or psPlatePlusZ.

Doubles[0..1]

[0] – Convection coefficient.

[1] – Ambient temperature.
