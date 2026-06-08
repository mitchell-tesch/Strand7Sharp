# St7GetVertexRMass3

Returns the rotational mass assigned to the specified vertex.

long St7GetVertexRMass3(long uID, long VertexNum, long* UCSId, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Vertex Attributes – Get

VertexNum

Vertex number.

Output Parameters

UCSId

ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.

Doubles[0..2]

A 3-element array defining the rotational mass for the vertex about the axes of the specified UCS.
