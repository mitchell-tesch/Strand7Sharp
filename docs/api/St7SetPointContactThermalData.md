# St7SetPointContactThermalData

Sets the thermal data required by the heat solvers for the specified Point Contact property.

long St7SetPointContactThermalData(long uID, long PropNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Properties – Beams, Plates and Bricks

PropNum

Beam property number.

Doubles[0..1]

[ipThermalArea] – Effective cross sectional area used to calculate heat capacity and flux.

[ipThermalMass] – The mass used to calculate heat capacity.
