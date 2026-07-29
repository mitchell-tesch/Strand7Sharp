# St7SetConnectionThermalData

Sets the thermal data required by the heat solvers for the specified Connection property.

long St7SetConnectionThermalData(long uID, long PropNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Beam property number.
Doubles[0..1]
[ipThermalArea] – Effective cross sectional area used to calculate heat capacity and flux.
[ipThermalMass] – The mass used to calculate heat capacity.
