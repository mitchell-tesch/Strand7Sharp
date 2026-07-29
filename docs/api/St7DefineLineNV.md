# St7DefineLineNV

Creates a new line definition based on one node and one vertex.

long St7DefineLineNV(long uID, long NodeNum, long VertexNum, bool Reversed,
long* LineID)
Input Parameters
uID
Strand7 model file ID.
NodeNum
Node number.
VertexNum
Vertex number.
Reversed
If True, line direction is oriented from the vertex to the node.
If False, line direction is oriented from the node to the vertex.
Output Parameters
LineID
Line identifier.
