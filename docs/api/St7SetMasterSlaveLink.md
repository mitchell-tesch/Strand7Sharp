# St7SetMasterSlaveLink

Assigns the parameters for the specified master-slave link.

long St7SetMasterSlaveLink(long uID, long LinkNum, long UCSId, long* Connection,

long* Integers)

Input Parameters

uID

Strand7 model file ID.

LinkNum

Link number.

UCSId

ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.

Connection[0..2]

[0] – Number of nodes in the link (2).

[1..2] – Node numbers.

Entities – Nodes, Elements and Links

Integers[0..5]

A 6-element array describing the relationship between each DoF in the linked nodes according to the
UCS axis system. Entries for each DoF may be one of msFree, msFix or msFixNegate.

Dependencies

Default Group

Target group for the link is specified by St7SetDefaultGroupID.
