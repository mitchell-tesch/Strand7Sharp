# St7GetVertexTemperatureType1

Returns the temperature type assigned to the specified vertex. This attribute is used when performing both
structural and heat transfer analysis. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetVertexTemperatureType1(long uID, long VertexNum, long CaseNum,

long* TType)

Input Parameters

uID

Strand7 model file ID.

VertexNum

Vertex number.

CaseNum

Load case number.

Output Parameters

TType

One of ntReferenceTemperature, ntFixedTemperature, ntInitialTemperature or ntTableTemperature.
