# St7GetBrickSoilLSMaterial

Returns the linear elastic soil parameters assigned to the specified brick property.

long St7GetBrickSoilLSMaterial(long uID, long PropNum, long* Integers,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

Brick property number.

Output Parameters

Integers[0..1]

[ipSoilLSSetPropLevel] – btTrue to set fluid level to Property value; btFalse to set fluid level to
Stage/Global level.

[ipSoilLSDrainedState] – Drained state; either btTrue or btFalse.

Properties – Beams, Plates and Bricks

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
