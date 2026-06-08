# St7SetMasterSlaveMultiPointLinkAttributes

Assigns attributes to a master-slave multi-point link.

long St7SetMasterSlaveMultiPointLinkAttributes(long uID, long LinkNum,

long UCSId, long DoFBits)

Input Parameters

uID

Strand7 model file ID.

Strand7 API Manual

LinkNum

Link number.

UCSId

ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.

DOFBits

Bitmask of flags for six degrees of freedom if Master-Slave links are created.  For example, to couple DX,
DY and RZ, set ConstraintBits = 1+2+32 = 35.
