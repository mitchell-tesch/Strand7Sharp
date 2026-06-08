# St7GetReactionMultiPointLink

Returns the parameters for the specified reaction multi-point link.

long St7GetReactionMultiPointLink(long uID, long LinkNum, long MaxNodes,
long* NumNodes, long* SetNum, long* Connection, double* Origin)

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

SetNum

Element set number defining the entities that contribute to the reaction multi-point link cluster.

Connection[0..Min(NumNodes,MaxNodes)-1]

Node numbers for linked nodes.

Origin[0..2]

Origin position in global XYZ coordinates.

Strand7 API Manual
