# St7SetBrickSoilMCMaterial

Assigns the Mohr-Coulomb soil parameters for the specified brick property.

long St7SetBrickSoilMCMaterial(long uID, long PropNum, long* Integers,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

Brick property number.

Integers[0..1]

[ipSoilMCSetPropLevel] – btTrue to set fluid level to Property value; btFalse to set fluid level to
Stage/Global level.

[ipSoilMCDrainedState] – Drained state; either btTrue or btFalse.

Doubles[0..11]

[ipSoilMCModulus] – Modulus.

[ipSoilMCPoisson] – Poisson’s ratio.

[ipSoilMCDensity] – Mass density per unit volume.

[ipSoilMCCohesion] – Cohesion value.

[ipSoilMCFrictionAngle] – Friction angle.

[ipSoilMCHorizontalRatio] – Horizontal stress ratio.

[ipSoilMCER] – Void ratio.

[ipSoilMCConductivity] – Conductivity.

Properties – Beams, Plates and Bricks

[ipSoilMCSpecificHeat] – Specific heat.

[ipSoilMCFluidLevel] – Fluid level.

[ipSoilMCViscosity] – Viscous damping coefficient.

[ipSoilMCDampingRatio] – Damping ratio.
