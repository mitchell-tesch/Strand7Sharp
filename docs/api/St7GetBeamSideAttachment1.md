# St7GetBeamSideAttachment1

Returns the side attachment properties for the specified beam. This attribute can be used to generate attachment
links using the St7CreateAttachments function.

long St7GetBeamSideAttachment1(long uID, long BeamNum, long BeamEnd,
long Direction, long* AttachType, long* ConnectType, long* PropNum,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BeamNum
Beam number.
BeamEnd
Beam end; either 1 or 2.
Direction
One of adPlus1, adMinus1, adPlus2 or adMinus2.
Output Parameters
AttachType
One of alDirect, alRigid or alFlexible.
ConnectType
Attachment sub-type; either alMoment or alPinned.
PropNum
Beam property number to be used for flexible type connections.
Doubles[0]
The maximum distance within which the beam can be attached to another element using the
attachment link.

Plate Attributes – Set
