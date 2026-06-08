# St7SetElementConnection

Sets the nodal connectivity and property ID for the specified element. A new entity is created if the element
number does not already exist. If the new element number is not consecutive with the existing element total a
series of null elements are created such that the element list remains contiguous. These null elements do not
have any connectivity or property ID assigned.

Entities – Nodes, Elements and Links

long St7SetElementConnection(long uID, long Entity, long EntityNum, long PropNum,

long* Connection)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyBEAM, tyPLATE, tyBRICK or tyLINK.

EntityNum

Entity number.

PropNum

The intended property ID or link type.

Where Entity is tyBEAM, tyPLATE or tyBRICK: the property ID of the new element.

Where Entity is tyLINK: one of ltAttachmentLink, ltCouplingLink, ltMasterSlaveLink, ltPinnedLink,
ltRigidLink, ltSectorSymmetryLink, ltShrinkLink or ltTwoPointLink.

Connection[0..kMaxElementNode]

[0] – Number of nodes in the element.

[1..20] – Node numbers in the element.

See Element Connections for additional information.

Dependencies

Default Group

Target group for the element is specified by St7SetDefaultGroupID.
