# St7GetPinnedMultiPointLink

Returns the parameters for the specified pinned multi-point link.

long St7GetPinnedMultiPointLink(long uID, long LinkNum, long MaxNodes,

long* NumNodes, long* Connection)

Input Parameters

uID

Strand7 model file ID.

LinkNum

Link number.

MaxNodes

The allocated size of the Connection array.  If the full connectivity of the link is required this should be
at least as large as the number of nodes attached to the link, which can be obtained using
St7GetNumMultiPointLinkNodes.

Output Parameters
NumNodes

The number of nodes in the link.

Connection[0..Min(NumNodes,MaxNodes)-1]

Node numbers for linked nodes, with the slave node specified first.
