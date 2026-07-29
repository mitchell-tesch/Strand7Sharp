# St7GetBrickCreepLoadingAge1

Returns the creep loading age assigned to the specified brick. This attribute is only used when performing creep
analysis using the quasi-static or nonlinear transient dynamic solvers.

long St7GetBrickCreepLoadingAge1(long uID, long BrickNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BrickNum
Brick number.
Output Parameters
Doubles[0]
Creep loading age in seconds.
