# St7GetBrickConvection2

Returns the thermal convection coefficient and ambient temperature assigned to the specified brick face. This
attribute is only used when performing heat transfer analysis. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetBrickConvection2(long uID, long BrickNum, long FaceNum, long CaseNum,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BrickNum
Brick number.
FaceNum
Local face number. See Brick Local Coordinates for additional information.
CaseNum
Load case number.
Output Parameters
Doubles[0..1]
[0] – Convection coefficient.
[1] – Ambient temperature.
