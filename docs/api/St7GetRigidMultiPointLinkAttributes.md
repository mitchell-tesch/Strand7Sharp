# St7GetRigidMultiPointLinkAttributes

Returns attributes assigned to a rigid multi-point link.

long St7GetRigidMultiPointLinkAttributes(long uID, long LinkNum, long* UCSId,

long* Axis)

Input Parameters

uID

Strand7 model file ID.

LinkNum

Link number.

Output Parameters

UCSId

ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.

Axis

One of rlPlaneXYZ, rlPlaneXY, rlPlaneYZ or rlPlaneZX.
