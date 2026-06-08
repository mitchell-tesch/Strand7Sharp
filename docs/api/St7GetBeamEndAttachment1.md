# St7GetBeamEndAttachment1

Returns the end attachment properties for the specified beam. This attribute can be used to generate attachment
links using the St7CreateAttachments function.

long St7GetBeamEndAttachment1(long uID, long BeamNum, long BeamEnd,

long* AttachType, long* ConnectType, long* PropNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BeamNum

Beam number.

BeamEnd

Beam end; either 1 or 2.

Output Parameters
AttachType

One of alDirect, alRigid or alFlexible.

ConnectType

Either alMoment or alPinned.

PropNum

Beam property number to be used for flexible type connections.

Beam Attributes – Get

Doubles[0]

The maximum distance within which the beam can be attached to another element using the
attachment link.
