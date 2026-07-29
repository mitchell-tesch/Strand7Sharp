# St7GetGeometryFaceHeatSource1

Returns the heat source assigned to the specified geometry face. See also St7GetEntityAttributeSequenceCount
and St7GetEntityAttributeSequence.

long St7GetGeometryFaceHeatSource1(long uID, long FaceNum, long CaseNum,
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
Heat source.
