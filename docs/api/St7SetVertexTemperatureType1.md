# St7SetVertexTemperatureType1

Sets the temperature type assigned at the specified vertex. This attribute is used when performing both structural
and heat transfer analysis.

long St7SetVertexTemperatureType1(long uID, long VertexNum, long CaseNum,
long TType)
Input Parameters
uID
Strand7 model file ID.
VertexNum
Vertex number.
CaseNum
Load case number.
TType
One of ntReferenceTemperature, ntFixedTemperature, ntInitialTemperature or ntTableTemperature.
