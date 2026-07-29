# St7GetNumElementsAtNode

Returns the number of elements connected to a node, based on a previously generated adjacency list.

long St7GetNumElementsAtNode(long uID, long AdjacencyIndex, long NodeNum,
long* NumElements)
Input Parameters
uID
Strand7 model file ID.
AdjacencyIndex
Index pointer to a previously generated adjacency list.
NodeNum
Node number.
Output Parameters
NumElements
The number of elements connected to the node.
