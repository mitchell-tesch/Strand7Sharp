# St7GetPlateEdgeAttachment1

Returns the attachment assigned to the specified plate edge. Attachment attributes can be used to generate
attachment links using the St7CreateAttachments function.

long St7GetPlateEdgeAttachment1(long uID, long PlateNum, long EdgeNum,

long Direction, long* AttachType, long* ConnectType, long* PropNum,
double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

EdgeNum

Local edge number; one of 1, 2, 3 or 4.

Direction

One of adPlanar, adPlusZ or adMinusZ.

Output Parameters
AttachType

One of alDirect, alRigid or alFlexible.

Strand7 API Manual

ConnectType

Either alMoment or alPinned.

PropNum

Beam property number used for flexible attachment types.

Doubles[0]

The maximum distance within which the plate edge can be connected to another element using the
attachment link.
