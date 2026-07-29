# St7GetPlateFluidMaterial

Returns the material properties assigned to the specified fluid plate property.

long St7GetPlateFluidMaterial(long uID, long PropNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Plate property number.

Output Parameters
Doubles[0..7]
[ipFluidModulus] – Modulus.
[ipFluidPenaltyParam] – Penalty parameter.
[ipFluidDensity] – Mass density per unit volume.
[ipFluidAlpha] – Thermal expansion coefficient.
[ipFluidViscosity] – Viscous damping coefficient.
[ipFluidDampingRatio] – Damping ratio.
[ipFluidConductivity] – Conductivity.
[ipFluidSpecificHeat] – Specific heat.
