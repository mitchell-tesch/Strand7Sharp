# St7SetPinnedMultiPointLink

Assigns the parameters for the specified pinned multi-point link.

long St7SetPinnedMultiPointLink(long uID, long LinkNum, long NumNodes,
long* Connection)
Input Parameters
uID
Strand7 model file ID.
LinkNum
Link number.
NumNodes
The number of nodes in the link.
Connection[0..NumNodes-1]
Node numbers for linked nodes, with the slave node specified first.

Dependencies
Default Group
Target group for the link is specified by St7SetDefaultGroupID.
