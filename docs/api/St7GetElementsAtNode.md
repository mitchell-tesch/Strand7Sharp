# St7GetElementsAtNode

Returns the number and type of elements connected to a node based on a previously generated adjacency list.

long St7GetElementsAtNode(long uID, long AdjacencyIndex, long NodeNum,
long* EntityNums, long* EntityTypes, long ArrayDim)
Input Parameters
uID
Strand7 model file ID.
AdjacencyIndex
Index pointer to a previously generated adjacency list.
NodeNum
Node number.
ArrayDim
Size of the arrays EntityNums and EntityTypes.
Output Parameters
EntityNums[0..ArrayDim-1]
[0..MIN(ArrayDim-1,NumElements)] – an array containing the element numbers for elements
connected to NodeNum. The maximum number of values returned in the array will be the minimum of
ArrayDim and the NumElements result returned by a call to St7GetNumElementsAtNode. If
EntityNums[0] is returned as 0, no elements are connected to the node. If ArrayDim is greater than
NumElements, EntityNums[NumElements] will be returned as 0 to signify the end of the list.

EntityTypes[0..ArrayDim-1]
[0..MIN(ArrayDim-1,NumElements)] – an array containing the element type (tyBEAM, tyPLATE,
tyBRICK or tyLINK) for elements connected to NodeNum. The maximum number of values returned in
the array will be the minimum of ArrayDim and the NumElements result returned by a call to
St7GetNumElementsAtNode. If EntityTypes[0] is returned as 0, no elements are connected to the node.
If ArrayDim is greater than NumElements, EntityTypes[NumElements] will be returned as 0 to signify the
end of the list.
