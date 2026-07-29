# St7GetGeometryFaceAttachment1

Returns the attachment conditions assigned to the specified geometry face. Attachment attributes can be used to
generate attachment links using the St7CreateAttachments function.

long St7GetGeometryFaceAttachment1(long uID, long FaceNum, long Surface,
long* AttachType, long* ConnectType, long* PropNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
FaceNum
Face number.
Surface
Local plate surface; either psPlateMinusZ or psPlatePlusZ.
Output Parameters
AttachType
One of alDirect, alRigid or alFlexible.
ConnectType
Attachment sub-type; either alMoment or alPinned.
PropNum
Beam property number used for flexible attachment types.
Doubles[0]
The maximum distance within which the face can be connected to another element using the
attachment link.
