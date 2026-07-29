# St7SetPlateFaceAttachment1

Assigns a face attachment to the specified plate surface. Attachment attributes can be used to generate
attachment links using the St7CreateAttachments function.

long St7SetPlateFaceAttachment1(long uID, long PlateNum, long Surface,
long AttachType, long ConnectType, long PropNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number.
Surface
Local plate surface; either psPlateMinusZ or psPlatePlusZ.
AttachType
One of alDirect, alRigid or alFlexible.
ConnectType
Attachment sub-type; either alMoment or alPinned.
PropNum
Beam property number used for flexible attachment types.
Doubles[0]
The maximum distance within which the plate surface can be connected to another element using the
attachment link.
