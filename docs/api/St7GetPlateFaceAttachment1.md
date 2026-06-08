# St7GetPlateFaceAttachment1

Returns the attachment assigned to the specified plate surface. Attachment attributes can be used to generate
attachment links using the St7CreateAttachments function.

long St7GetPlateFaceAttachment1(long uID, long PlateNum, long Surface,

long* AttachType, long* ConnectType, long* PropNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

Surface

Local plate surface; either psPlateMinusZ or psPlatePlusZ.

Output Parameters
AttachType

One of alDirect, alRigid or alFlexible.

ConnectType

Either alMoment or alPinned.

PropNum

Beam property number used for flexible attachment types.

Doubles[0]

The maximum distance within which the plate surface can be connected to another element using the
attachment link.
