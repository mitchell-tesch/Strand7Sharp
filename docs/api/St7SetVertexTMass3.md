# St7SetVertexTMass3

Assigns a translational mass to the specified vertex as three components.

long St7SetVertexTMass3(long uID, long VertexNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

VertexNum

Vertex number.

Doubles[0..2]

A 3-element array describing the translational mass for the specified vertex in the global XYZ system.
