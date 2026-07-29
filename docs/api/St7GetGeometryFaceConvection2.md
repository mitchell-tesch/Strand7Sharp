# St7GetGeometryFaceConvection2

Returns the thermal convection coefficient and ambient temperature assigned to the specified geometry face.
This attribute is only used when performing heat transfer analysis. See also St7GetEntityAttributeSequenceCount
and St7GetEntityAttributeSequence.

long St7GetGeometryFaceConvection2(long uID, long FaceNum, long CaseNum,
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

Output Parameters
Doubles[0..1]
[0] – Convection coefficient.
[1] – Ambient temperature.
