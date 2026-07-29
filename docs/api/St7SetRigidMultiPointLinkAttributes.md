# St7SetRigidMultiPointLinkAttributes

Assigns attributes to a rigid multi-point link.

long St7SetRigidMultiPointLinkAttributes(long uID, long LinkNum, long UCSId,
long Axis)
Input Parameters
uID
Strand7 model file ID.
LinkNum
Link number.
UCSId
ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.
Axis
One of rlPlaneXYZ, rlPlaneXY, rlPlaneYZ or rlPlaneZX.
