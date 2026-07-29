# St7GetBeamRadiation2

Returns the thermal radiation coefficient and ambient temperature assigned to the specified beam. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetBeamRadiation2(long uID, long BeamNum, long BeamEnd, long CaseNum,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BeamNum
Beam number.
BeamEnd
Beam end; either 1 or 2.
CaseNum
Load case number.
Output Parameters
Doubles[0..1]
[0] – Radiation coefficient.
[1] – Ambient temperature.
