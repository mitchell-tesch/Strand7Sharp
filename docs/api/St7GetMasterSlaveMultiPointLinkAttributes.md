# St7GetMasterSlaveMultiPointLinkAttributes

Returns attributes assigned to a master-slave multi-point link.

long St7GetMasterSlaveMultiPointLinkAttributes(long uID, long LinkNum,

long* UCSId, long* DoFBits)

Input Parameters

uID

Strand7 model file ID.

Link Attributes – Get

LinkNum

Link number.

Output Parameters

UCSId

ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.

DOFBits

Bitmask of flags for six degrees of freedom if Master-Slave links are created.  For example, to couple DX,
DY and RZ, set ConstraintBits = 1+2+32 = 35.
