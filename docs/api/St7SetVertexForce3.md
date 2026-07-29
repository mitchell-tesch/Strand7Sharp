# St7SetVertexForce3

Assigns a point force to the specified vertex.

long St7SetVertexForce3(long uID, long VertexNum, long CaseNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
VertexNum
Vertex number.

CaseNum
Load case number.
Doubles[0..2]
A 3-element array containing the force defined in the global XYZ system for the specified vertex.
