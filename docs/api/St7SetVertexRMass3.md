# St7SetVertexRMass3

Assigns a rotational mass to the specified vertex.

long St7SetVertexRMass3(long uID, long VertexNum, long UCSId, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
VertexNum
Vertex number.
UCSId
ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.
Doubles[0..2]
A 3-element array defining the rotational mass for the vertex about the axes of the specified UCS.
