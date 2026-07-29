# St7GetGeometryLoopCoedges

Returns the edge numbers for the specified loop. Use St7GetNumGeometryLoopCoedges to determine the
number of edges in the specified loop.

long St7GetGeometryLoopCoedges(long uID, long LoopNum, long MaxCoedges,
long* Integers)
Input Parameters
uID
Strand7 model file ID.
LoopNum
Loop number.
MaxCoedges
Maximum amount of storage allocated for Integers. Returns all coedges if set greater than or equal to
NumCoedges.
Output Parameters
Integers[0..MaxCoedges-1]
An array containing the coedge numbers for the specified loop such that Integers[i-1] contains the
ith coedge number.
