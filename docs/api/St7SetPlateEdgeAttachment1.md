# St7SetPlateEdgeAttachment1

Assigns an edge attachment to the specified plate edge. Attachment attributes can be used to generate
attachment links using the St7CreateAttachments function.

long St7SetPlateEdgeAttachment1(long uID, long PlateNum, long EdgeNum,
long Direction, long AttachType, long ConnectType, long PropNum,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number.
EdgeNum
Local edge number; one of 1, 2, 3 or 4.
Direction
Direction of attachment; one of adPlanar, adPlusZ or adMinusZ.
AttachType
One of alDirect, alRigid or alFlexible.

ConnectType
Attachment sub-type; either alMoment or alPinned.
PropNum
Beam property number used for flexible attachment types.
Doubles[0]
The maximum distance within which the plate edge can be connected to another element using the
attachment link.
