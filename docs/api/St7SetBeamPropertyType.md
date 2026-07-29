# St7SetBeamPropertyType

Sets the beam type for the specified beam property.

long St7SetBeamPropertyType(long uID, long PropNum, long BeamType)
Input Parameters
uID
Strand7 model file ID.
PropNum
Property number.
BeamType
One of btSpring, btCable, btTruss, btCutoff, btContact, btBeam, btUser, btPipe or btConnection.
