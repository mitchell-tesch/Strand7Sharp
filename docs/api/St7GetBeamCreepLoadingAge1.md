# St7GetBeamCreepLoadingAge1

Returns the creep loading age for the specified beam. This attribute is only used when performing a creep analysis
using the quasi-static or nonlinear transient dynamic solvers.

long St7GetBeamCreepLoadingAge1(long uID, long BeamNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BeamNum
Beam number.
Output Parameters
Doubles[0]
Creep loading age in seconds.
