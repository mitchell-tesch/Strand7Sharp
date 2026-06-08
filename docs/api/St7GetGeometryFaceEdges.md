# St7GetGeometryFaceEdges

Returns the edge numbers for the specified geometry face. Use St7GetNumGeometryFaceEdges to determine the
number of edges in the specified geometry face.

long St7GetGeometryFaceEdges(long uID, long FaceNum, long MaxEdges,

long* Integers)

Input Parameters

uID

Strand7 model file ID.

FaceNum

Face number.

MaxEdges

Maximum amount of storage allocated for Integers.  Returns all edges if set greater than or equal to
NumEdges.

Strand7 API Manual

Output Parameters

Integers[0..MaxEdges-1]

An array containing the edge numbers for the specified face such that Integers[i-1] contains the ith
edge number.
