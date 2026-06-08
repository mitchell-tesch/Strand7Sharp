# St7SetGeometryCoedgeAttachment1

Assigns an attachment attribute to the specified geometry coedge. Attachment attributes can be used to generate
attachment links using the St7CreateAttachments function.

long St7SetGeometryCoedgeAttachment1(long uID, long CoedgeNum, long Direction,

long AttachType, long ConnectType, long PropNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

CoedgeNum

Coedge number.

Direction

Direction of attachment; one of adPlanar, adPlusZ or adMinusZ.

AttachType

One of alDirect, alRigid or alFlexible.

ConnectType

Attachment sub-type; either alMoment or alPinned.

Strand7 API Manual

PropNum

Beam property number used for flexible attachment types.

Doubles[0]

The maximum distance within which the edge can be connected to another element using the
attachment link.

Coedge Attributes – Get

Coedge Attributes – Get
