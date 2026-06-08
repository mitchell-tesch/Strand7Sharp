# St7GetBeamPropertyType

Returns the beam type for the specified beam property.

Strand7 API Manual

long St7GetBeamPropertyType(long uID, long PropNum, long* BeamType)

Input Parameters

uID

Strand7 model file ID.

PropNum

Property number.

Output Parameters
BeamType

One of btNull, btSpring, btCable, btTruss, btCutoff, btContact, btBeam, btUser, btPipe or btConnection.
