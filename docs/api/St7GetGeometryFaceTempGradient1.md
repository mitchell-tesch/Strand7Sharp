# St7GetGeometryFaceTempGradient1

Returns the temperature gradient assigned to the specified geometry face. This attribute is only used when
performing structural analysis. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetGeometryFaceTempGradient1(long uID, long FaceNum, long CaseNum,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
FaceNum
Face number.
CaseNum
Load case number.
Output Parameters
Doubles[0]
Temperature gradient.
