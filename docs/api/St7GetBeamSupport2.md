# St7GetBeamSupport2

Returns the elastic support value assigned to the specified beam. See also St7GetEntityAttributeSequenceCount
and St7GetEntityAttributeSequence.

long St7GetBeamSupport2(long uID, long BeamNum, long Direction, long CaseNum,
long* Status, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BeamNum
Beam number.
Direction
The support direction in principal axes of the beam. One of adMinus1, adPlus1, adMinus2 or adPlus2.
See Beam Local Coordinates.
CaseNum
Freedom case number.
Output Parameters
Status
Compression-only flag; either btTrue or btFalse.
Doubles[0..1]
[0] – The support stiffness.
[1] – The support gap. This parameter is only relevant if the compression-only flag is set to btTrue.
