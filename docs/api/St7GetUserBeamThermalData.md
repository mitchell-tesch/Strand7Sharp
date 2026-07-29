# St7GetUserBeamThermalData

Returns the thermal data set for the specified user defined beam property that is required by the heat solvers.

long St7GetUserBeamThermalData(long uID, long PropNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Beam property number.
Output Parameters
Doubles[0..1]
[ipThermalArea] – Effective cross sectional area used to calculate heat capacity and flux.
[ipThermalMass] – The mass used to calculate heat capacity.
