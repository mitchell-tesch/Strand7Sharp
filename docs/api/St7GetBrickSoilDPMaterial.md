# St7GetBrickSoilDPMaterial

Returns the Drucker-Prager soil parameters assigned to the specified brick property.

long St7GetBrickSoilDPMaterial(long uID, long PropNum, long* Integers,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Brick property number.
Output Parameters
Integers[0..1]
[ipSoilDPSetPropLevel] – btTrue to set fluid level to Property value; btFalse to set fluid level to
Stage/Global level.
[ipSoilDPDrainedState] – Drained state; either btTrue or btFalse.
Doubles[0..11]
[ipSoilDPModulus] – Modulus.
[ipSoilDPPoisson] – Poisson’s ratio.
[ipSoilDPDensity] – Mass density per unit volume.
[ipSoilDPCohesion] – Cohesion value.
[ipSoilDPFrictionAngle] – Friction angle.
[ipSoilDPHorizontalRatio] – Horizontal stress ratio.
[ipSoilDPER] – Void ratio.
[ipSoilDPConductivity] – Conductivity.
[ipSoilDPSpecificHeat] – Specific heat.
[ipSoilDPFluidLevel] – Fluid level.
[ipSoilDPViscosity] – Viscous damping coefficient.
[ipSoilDPDampingRatio] – Damping ratio.
