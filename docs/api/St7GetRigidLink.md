# St7GetRigidLink

Returns the parameters for the specified rigid link.

long St7GetRigidLink(long uID, long LinkNum, long* UCSId, long* Plane,
long* Connection)
Input Parameters
uID
Strand7 model file ID.
LinkNum
Link number.
Output Parameters
UCSId
ID number of the specified Cartesian UCS. UCSId = 1 refers to the global XYZ system.
Plane
One of rlPlaneXYZ, rlPlaneXY, rlPlaneYZ or rlPlaneZX.
Connection[0..2]
[0] – Number of nodes in the link (2).
[1..2] – Node numbers.
