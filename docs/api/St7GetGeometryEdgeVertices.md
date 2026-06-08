# St7GetGeometryEdgeVertices

Returns the vertex numbers in the specified geometry edge.

long St7GetGeometryEdgeVertices(long uID, long EdgeNum, long* EdgeVertices)

Input Parameters

uID

Strand7 model file ID.

EdgeNum

Edge number.

Output Parameters

EdgeVertices[0..1]

A 2-element array containing the start and end vertices for the specified edge.
