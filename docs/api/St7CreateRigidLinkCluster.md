# St7CreateRigidLinkCluster

Creates a rigid link cluster between selected nodes, such that they act as a rigid body.

long St7CreateRigidLinkCluster(long uID, long UCSId, long Axis, long NodeNum)
Input Parameters
uID
Strand7 model file ID.
UCSId
The Cartesian coordinate system in which the rigid plane is prescribed. Not relevant if Axis is rlPlaneXYZ.
Axis
One of rlPlaneXYZ, rlPlaneXY, rlPlaneYZ or rlPlaneZX.
NodeNum
Slave node number, or 0 to create a new slave node at the average position of the selected nodes.
Dependencies
Selection
Nodes can be selected using functions in Entity Selection.
Default Group
Target group for the links is specified by St7SetDefaultGroupID.
