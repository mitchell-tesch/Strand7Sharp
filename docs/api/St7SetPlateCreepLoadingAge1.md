# St7SetPlateCreepLoadingAge1

Sets the creep loading age for the specified plate. This attribute is only active when conducting creep analysis
using the quasi-static or nonlinear transient dynamic solvers.

long St7SetPlateCreepLoadingAge1(long uID, long PlateNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number.
Doubles[0]
Creep loading age in seconds.
