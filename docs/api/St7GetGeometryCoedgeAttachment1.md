# St7GetGeometryCoedgeAttachment1

Returns the edge attachment attribute assigned to the specified geometry coedge. Attachment attributes can be
used to generate attachment links using the St7CreateAttachments function.

long St7GetGeometryCoedgeAttachment1(long uID, long CoedgeNum, long Direction,
long* AttachType, long* ConnectType, long* PropNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

CoedgeNum

Coedge number.

Direction

One of adPlanar, adPlusZ or adMinusZ.

Output Parameters
AttachType

One of alDirect, alRigid or alFlexible.

ConnectType

Attachment sub-type; either alMoment or alPinned.

PropNum

Beam property number used for flexible attachment types.

Doubles[0]

The maximum distance within which the brick face can be connected to another element using the
attachment link.

Strand7 API Manual

Face Attributes – Set
