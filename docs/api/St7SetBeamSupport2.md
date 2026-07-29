# St7SetBeamSupport2

Sets the elastic support value for the specified beam.

long St7SetBeamSupport2(long uID, long BeamNum, long Direction, long CaseNum,
long Status, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BeamNum
Beam number.
Direction
One of adMinus1, adPlus1, adMinus2 or adPlus2. See Beam Local Coordinates.
CaseNum
Freedom case number.
Status
Compression-only flag; either btTrue or btFalse.
Doubles[0..1]
[0] – The support stiffness.
[1] – The support gap. This parameter is only relevant if the compression-only flag is set to btTrue.
