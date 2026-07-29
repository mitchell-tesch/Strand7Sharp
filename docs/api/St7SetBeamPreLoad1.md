# St7SetBeamPreLoad1

Sets the pre-load conditions for the specified beam.

long St7SetBeamPreLoad1(long uID, long BeamNum, long CaseNum, long LoadType,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BeamNum
Beam number.
CaseNum
Load case number.

LoadType
The type of pre-load, plBeamPreTension or plBeamPreStrain.
Doubles[0]
The pre-load value.
