# St7GetVertexTemperatureTable

Returns the table associated with the specified vertex. This attribute is used when performing both structural and
heat transfer analysis. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

Vertex Attributes – Get

long St7GetVertexTemperatureTable(long uID, long VertexNum, long CaseNum,

long* TableID)

Input Parameters

uID

Strand7 model file ID.

VertexNum

Vertex number.

CaseNum

Load case number.

Output Parameters

TableID

Temperature vs Time table ID associated with the vertex temperature, or 0 for none.
