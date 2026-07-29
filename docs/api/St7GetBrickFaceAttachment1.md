# St7GetBrickFaceAttachment1

Returns the attachment conditions assigned to the specified brick face. Attachment attributes can be used to
generate attachment links using the St7CreateAttachments function.

long St7GetBrickFaceAttachment1(long uID, long BrickNum, long FaceNum,
long* AttachType, long* ConnectType, long* PropNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BrickNum
Brick number.
FaceNum
Local face number. See Brick Local Coordinates for additional information.
Output Parameters
AttachType
One of alDirect, alRigid or alFlexible.
ConnectType
Either alMoment or alPinned.
PropNum
Beam property number used for flexible attachment types.

Doubles[0]
The maximum distance within which the brick face can be connected to another element using the
attachment link.
