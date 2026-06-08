# St7GetVertexHeatSourceTables

Returns the tables associated with the heat source assigned to the specified vertex. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

Vertex Attributes – Get

long St7GetVertexHeatSourceTables(long uID, long VertexNum, long CaseNum,

long* Tables)

Input Parameters

uID

Strand7 model file ID.

VertexNum

Vertex number.

CaseNum

Load case number.

Output Parameters
Tables[0..1]

[0] – Factor vs Time table ID associated with the heat source, or 0 for none.

[1] – Factor vs Temperature table ID associated with the heat source, or 0 for none.

Strand7 API Manual

Edge Attributes – Set
