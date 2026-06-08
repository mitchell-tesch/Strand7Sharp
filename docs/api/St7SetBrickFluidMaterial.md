# St7SetBrickFluidMaterial

Sets the fluid material properties for the specified brick property.

long St7SetBrickFluidMaterial(long uID, long PropNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

Brick property number.

Doubles[0..7]

[ipFluidModulus] – Modulus.

[ipFluidPenaltyParam] – Penalty parameter.

[ipFluidDensity] – Mass density per unit volume.

[ipFluidAlpha] – Thermal expansion coefficient.

[ipFluidViscosity] – Viscous damping coefficient.

[ipFluidDampingRatio] – Damping ratio.

[ipFluidConductivity] – Conductivity.

[ipFluidSpecificHeat] – Specific heat.
