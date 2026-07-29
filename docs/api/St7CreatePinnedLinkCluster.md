# St7CreatePinnedLinkCluster

Creates a pinned link cluster between selected nodes.

long St7CreatePinnedLinkCluster(long uID, long NodeNum)
Input Parameters
uID
Strand7 model file ID.

NodeNum
Slave node number, or 0 to create a new slave node at the average position of the selected nodes.
Dependencies
Selection
Nodes can be selected using functions in Entity Selection.
Default Group
Target group for the links is specified by St7SetDefaultGroupID.
