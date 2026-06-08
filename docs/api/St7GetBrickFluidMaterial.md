# St7GetBrickFluidMaterial

Returns the fluid material properties assigned to the specified brick property.

Strand7 API Manual

long St7GetBrickFluidMaterial(long uID, long PropNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

Brick property number.

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
