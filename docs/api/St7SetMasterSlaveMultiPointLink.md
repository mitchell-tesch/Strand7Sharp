# St7SetMasterSlaveMultiPointLink

Assigns the parameters for the specified master-slave multi-point link.

long St7SetMasterSlaveMultiPointLink(long uID, long LinkNum, long NumNodes,

long UCSId, long DOFBits, long* Connection)

Input Parameters

uID

Strand7 model file ID.

LinkNum

Link number.

NumNodes

The number of nodes in the link.

UCSId

ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.

DOFBits

Bitmask of flags for six degrees of freedom if Master-Slave links are created.  For example, to couple DX,
DY and RZ, set ConstraintBits = 1+2+32 = 35.

Connection[0..NumNodes-1]

Node numbers for linked nodes, with the slave node specified first.

Dependencies

Default Group

Target group for the link is specified by St7SetDefaultGroupID.
