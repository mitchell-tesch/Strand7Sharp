# St7CreateReactionMultiPointLink

Creates a reaction multi-point link.

long St7CreateReactionMultiPointLink(long uID, long SetNum, long OriginCode,

double* Origin)

Input Parameters

uID

Strand7 model file ID.

SetNum

Element set number defining the entities that contribute to the reaction multi-point link cluster.

OriginCode

One of ocUseOrigin (to use the specified origin); ocUseNodeAverage (to use the average position of the
selected nodes); or any node number (to place the origin at the position of the specified node).

Strand7 API Manual

Origin[0..2]

Location of origin in global XYZ coordinates, about which moments are calculated.

Dependencies
Selection

Nodes can be selected using functions in Entity Selection.

Default Group

Target group for the links is specified by St7SetDefaultGroupID.
