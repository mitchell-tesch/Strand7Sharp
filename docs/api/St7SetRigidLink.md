# St7SetRigidLink

Assigns the parameters for the specified rigid link.

long St7SetRigidLink(long uID, long LinkNum, long UCSId, long Plane,

long* Connection)

Input Parameters

uID

Strand7 model file ID.

Entities – Nodes, Elements and Links

LinkNum

Link number.

UCSId

ID number of the specified Cartesian UCS. UCSId = 1 refers to the global XYZ system.

Plane

One of rlPlaneXYZ, rlPlaneXY, rlPlaneYZ or rlPlaneZX.

Connection[0..2]

[0] – Number of nodes in the link (2).

[1..2] – Node numbers.

Dependencies

Default Group

Target group for the link is specified by St7SetDefaultGroupID.
