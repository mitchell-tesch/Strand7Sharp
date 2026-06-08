# St7GetReactionMultiPointLinkAttributes

Returns attributes assigned to a reaction multi-point link.

long St7GetReactionMultiPointLinkAttributes(long uID, long LinkNum, long* SetNum,

double* Origin)

Input Parameters

uID

Strand7 model file ID.

LinkNum

Link number.

Strand7 API Manual

Output Parameters

SetNum

Element set number defining the entities that contribute to the reaction multi-point link cluster.

Origin[0..2]

Origin position in global XYZ coordinates.

Vertex Attributes – Set

Vertex Attributes – Set
