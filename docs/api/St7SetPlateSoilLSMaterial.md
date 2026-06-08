# St7SetPlateSoilLSMaterial

Sets the linear elastic soil parameters for the specified plate property.

long St7SetPlateSoilLSMaterial(long uID, long PropNum, long* Integers,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

Property number.

Integers[0..1]

[ipSoilLSSetPropLevel] – btTrue to set fluid level to Property value; btFalse to set fluid level to
Stage/Global level.

Properties – Beams, Plates and Bricks

[ipSoilLSDrainedState] – Drained state; either btTrue or btFalse.

Doubles[0..9]

[ipSoilLSModulus] – Modulus.

[ipSoilLSPoisson] – Poisson’s ratio.

[ipSoilLSDensity] – Mass density per unit volume.

[ipSoilLSHorizontalRatio] – Horizontal stress ratio.

[ipSoilLSER] – Void ratio.

[ipSoilLSConductivity] – Conductivity.

[ipSoilLSSpecificHeat] – Specific heat.

[ipSoilLSFluidLevel] – Fluid level.

[ipSoilLSViscosity] – Viscous damping coefficient.

[ipSoilLSDampingRatio] – Damping ratio.
