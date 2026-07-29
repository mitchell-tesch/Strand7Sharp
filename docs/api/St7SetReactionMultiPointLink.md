# St7SetReactionMultiPointLink

Assigns the parameters for the specified reaction multi-point link.

long St7SetReactionMultiPointLink(long uID, long LinkNum, long NumNodes,
long SetNum, long* Connection, double* Origin)
Input Parameters
uID
Strand7 model file ID.
LinkNum
Link number.

NumNodes
The number of nodes in the link.
SetNum
Element set number defining the entities that contribute to the reaction multi-point link cluster.
Connection[0..NumNodes-1]
Node numbers for linked nodes.
Origin[0..2]
Origin position in global XYZ coordinates.
Dependencies
Default Group
Target group for the link is specified by St7SetDefaultGroupID.
