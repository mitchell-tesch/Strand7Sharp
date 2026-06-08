# St7GetGeometryFaceRadiation2

Returns the thermal radiation coefficient and ambient temperature assigned to the specified geometry face. See
also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetGeometryFaceRadiation2(long uID, long FaceNum, long CaseNum,

long Surface, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Strand7 API Manual

FaceNum

Face number.

CaseNum

Load case number.

Surface

Local plate surface; either psPlateMinusZ or psPlatePlusZ.

Output Parameters
Doubles[0..1]

[0] – Radiation coefficient.

[1] – Ambient temperature.
