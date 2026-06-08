# St7GetVertexTMass3

Returns the translational mass assigned to the specified vertex.

long St7GetVertexTMass3(long uID, long VertexNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

VertexNum

Vertex number.

Output Parameters
Doubles[0..2]

A 3-element array describing the translational mass for the specified vertex in the global XYZ system.
