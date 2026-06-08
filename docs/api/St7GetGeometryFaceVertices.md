# St7GetGeometryFaceVertices

Returns the vertex numbers for the specified geometry face. Use St7GetNumGeometryFaceVertices to determine
the number of vertices for the specified geometry face.

Strand7 API Manual

long St7GetGeometryFaceVertices(long uID, long FaceNum, long MaxVertices,

long* Integers)

Input Parameters

uID

Strand7 model file ID.

FaceNum

Face number.

MaxVertices

Maximum amount of storage allocated for Integers.  Returns all vertices if set greater than or equal to
NumVertices.

Output Parameters

Integers[0..MaxVertices-1]

An array containing the vertex numbers for the specified face such that Integers[i-1] contains the
ith vertex number.
