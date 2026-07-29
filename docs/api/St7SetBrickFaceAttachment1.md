# St7SetBrickFaceAttachment1

Assigns an attachment to the specified brick face. Attachment attributes can be used to generate attachment links
using the St7CreateAttachments function.

long St7SetBrickFaceAttachment1(long uID, long BrickNum, long FaceNum,
long AttachType, long ConnectType, long PropNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BrickNum
Brick number.
FaceNum
Local face number. See Brick Local Coordinates for additional information.
AttachType
One of alDirect, alRigid or alFlexible.
ConnectType
Attachment sub-type; either alMoment or alPinned.
PropNum
Beam property number used for flexible attachment types.

Doubles[0]
The maximum distance within which the brick face can be connected to another element using the
attachment link.
