# St7GetGeometryFaceCoedges

Returns the coedge numbers for the specified geometry face. Use St7GetNumGeometryFaceCoedges to determine
the number of coedges in the specified geometry face.

long St7GetGeometryFaceCoedges(long uID, long FaceNum, long MaxCoedges,

long* Integers)

Input Parameters

uID

Strand7 model file ID.

FaceNum

Face number.

MaxCoedges

Maximum amount of storage allocated for Integers.  Returns all coedges if set greater than or equal to
NumCoedges.

Output Parameters

Integers[0..MaxCoedges-1]

An array containing the coedge numbers for the specified face such that Integers[i-1] contains the
ith coedge number.
