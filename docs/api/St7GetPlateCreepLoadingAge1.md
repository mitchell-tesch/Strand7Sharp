# St7GetPlateCreepLoadingAge1

Returns the creep loading age assigned to the specified plate. This attribute is only active when conducting creep
analysis using the quasi-static or nonlinear transient dynamic solvers.

long St7GetPlateCreepLoadingAge1(long uID, long PlateNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number.
Output Parameters
Doubles[0]
Creep loading age in seconds.
