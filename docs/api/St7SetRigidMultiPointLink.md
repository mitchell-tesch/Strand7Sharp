# St7SetRigidMultiPointLink

Assigns the parameters for the specified rigid multi-point link.

long St7SetRigidMultiPointLink(long uID, long LinkNum, long NumNodes, long UCSId,
long Axis, long* Connection)
Input Parameters
uID
Strand7 model file ID.
LinkNum
Link number.
NumNodes
The number of nodes in the link.

UCSId
ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.
Axis
One of rlPlaneXYZ, rlPlaneXY, rlPlaneYZ or rlPlaneZX.
Connection[0..NumNodes-1]
Node numbers for linked nodes, with the slave node specified first.
Dependencies
Default Group
Target group for the link is specified by St7SetDefaultGroupID.
