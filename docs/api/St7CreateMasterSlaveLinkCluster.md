# St7CreateMasterSlaveLinkCluster

Creates a master-slave link cluster between selected nodes.

long St7CreateMasterSlaveLinkCluster(long uID, long UCSId, long DoFBits,

long NodeNum)

Input Parameters

uID

Strand7 model file ID.

UCSId

The coordinate system in which the degrees of freedom are defined.

DoFBits

Bitmask of flags for six degrees of freedom if Master-Slave links are created.  For example, to couple DX,
DY and RZ, set ConstraintBits = 1+2+32 = 35.

NodeNum

Slave node number, or 0 to create a new slave node at the average position of the selected nodes.

Dependencies
Selection

Nodes can be selected using functions in Entity Selection.

Default Group

Target group for the link is specified by St7SetDefaultGroupID.
