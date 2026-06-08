# St7SetVertexTemperatureTable

Specifies the table to be associated with the temperature assigned to the specified vertex. This attribute is used
when performing both structural and heat transfer analysis.

long St7SetVertexTemperatureTable(long uID, long VertexNum, long CaseNum,

long TableID)

Input Parameters

uID

Strand7 model file ID.

VertexNum

Vertex number.

CaseNum

Load case number.

TableID

Temperature vs Time table ID associated with the vertex temperature, or 0 for none.
