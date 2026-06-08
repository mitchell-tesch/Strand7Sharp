# St7GetVertexTemperature1

Returns the temperature assigned to the specified vertex. This attribute is used when conducting both structural
and heat transfer analysis. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

Strand7 API Manual

long St7GetVertexTemperature1(long uID, long VertexNum, long CaseNum,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

VertexNum

Vertex number.

CaseNum

Load case number.

Output Parameters
Doubles[0]

Applied temperature value.
