# St7SetBeamRadiation2

Sets the thermal radiation coefficient and ambient temperature for the specified beam.

long St7SetBeamRadiation2(long uID, long BeamNum, long BeamEnd, long CaseNum,
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
Doubles[0..1]
[0] – Radiation coefficient.
[1] – Ambient temperature.
