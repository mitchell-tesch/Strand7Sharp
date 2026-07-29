# St7GetVertexHeatSource1

Returns the heat source assigned to the specified vertex. This attribute is only used when performing heat
transfer analysis. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetVertexHeatSource1(long uID, long VertexNum, long CaseNum,
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
Heat source.
