# St7GetGeometryFaceRadiationTables

Returns the tables associated with the radiation coefficient assigned to the specified geometry face surface. See
also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetGeometryFaceRadiationTables(long uID, long FaceNum, long CaseNum,
long Surface, long* Tables)
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
Tables[0..2]
[0] – Temperature vs Time table ID associated with the radiation ambient temperature, or 0 for none.
[1] – Factor vs Temperature table ID associated with the radiation coefficient, or 0 for none.
[2] – Factor vs Time table ID associated with the radiation coefficient, or 0 for none.
