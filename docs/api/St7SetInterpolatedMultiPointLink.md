# St7SetInterpolatedMultiPointLink

Assigns the parameters for the specified interpolated multi-point link.

long St7SetInterpolatedMultiPointLink(long uID, long LinkNum, long NumNodes,
long Couple, long* Connection)
Input Parameters
uID
Strand7 model file ID.
LinkNum
Link number.
NumNodes
The number of nodes in the link.
Couple
One of cpTranslational, cpRotational or cpBoth.
Connection[0..NumNodes-1]
Node numbers for linked nodes, with the slave node specified first.
Dependencies
Default Group
Target group for the link is specified by St7SetDefaultGroupID.
