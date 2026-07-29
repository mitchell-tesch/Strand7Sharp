# St7SetResFileBeamResult

Sets the specified beam result quantities for a given beam element and result case in the custom result file.

long St7SetResFileBeamResult(long uID, long CaseNum, long BeamNum, long Quantity,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Result case number.
BeamNum
Beam number.
Quantity
One of rtBeamForce, rtBeamAllStrain, rtBeamNodeReact, rtBeamFlux or rtBeamNodeFlux.
Doubles[..]
An array defining the specified beam result quantity at each station along the beam. See Custom Results
for additional information.
