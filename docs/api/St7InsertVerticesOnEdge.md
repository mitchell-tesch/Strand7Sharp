# St7InsertVerticesOnEdge

Inserts vertices at prescribed positions along an edge.

long St7InsertVerticesOnEdge(long uID, long EdgeID, long NumVertex,

long VertexType, double* Positions)

Input Parameters

uID

Strand7 model file ID.

EdgeID

Edge number on which to insert vertices.

NumVertex

Number of positions along edge to insert vertices.

VertexType

Either vtFree or vtFixed.

Positions[0..NumVertex-1]

Positions along edge to insert vertices, normalised to the range 0.0 to 1.0.  Duplicated or out-of-range
positions are ignored by the function.
