# St7GetGeometryLoopEdges

Returns the edge numbers for the specified loop. Use St7GetNumGeometryLoopEdges to determine the number
of edges in the specified loop.

long St7GetGeometryLoopEdges(long uID, long LoopNum, long MaxEdges,
long* Integers)
Input Parameters
uID
Strand7 model file ID.
LoopNum
Loop number.
MaxEdges
Maximum amount of storage allocated for Integers. Returns all edges if set greater than or equal to
NumEdges.
Output Parameters
Integers[0..MaxEdges-1]
An array containing the edge numbers for the specified loop such that Integers[i-1] contains the ith
edge number.
