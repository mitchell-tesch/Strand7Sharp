# St7SetBeamFlux1

Sets the heat flux for the specified beam.

long St7SetBeamFlux1(long uID, long BeamNum, long BeamEnd, long CaseNum,
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
Doubles[0]
Heat flux through the beam.
