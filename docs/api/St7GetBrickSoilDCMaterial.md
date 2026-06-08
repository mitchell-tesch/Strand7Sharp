# St7GetBrickSoilDCMaterial

Returns the Duncan-Chang soil material properties assigned to the specified brick property.

long St7GetBrickSoilDCMaterial(long uID, long PropNum, long* Integers,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

Brick property number.

Output Parameters

Integers[0..2]

[ipSoilDCUseBulkModulus] – Use bulk modulus; either btTrue or btFalse.

[ipSoilDCSetPropLevel] – btTrue to set fluid level to Property value; btFalse to set fluid level to
Stage/Global level.

[ipSoilDCDrainedState] – Drained state; either btTrue or btFalse.

Doubles[0..19]

[ipSoilDCModulusK] – Modulus.

[ipSoilDCModulusKUR] – Unloading/reloading modulus.

[ipSoilDCModulusN] – Modulus exponent.

[ipSoilDCPoisson] – Poisson’s ratio.

[ipSoilDCBulkK] – Bulk modulus.

[ipSoilDCBulkM] – Bulk modulus exponent.

[ipSoilDCFrictionAngle] – Friction angle.

[ipSoilDCDeltaAngle] – Friction angle change.

[ipSoilDCCohesion] – Cohesion value.

[ipSoilDCFailureRatio] – Failure ratio.

[ipSoilDCFailureMod] – Failure modulus.

[ipSoilDCReferenceP] – Reference pressure.

[ipSoilDCDensity] – Mass density per unit volume.

Strand7 API Manual

[ipSoilDCHorizontalRatio] – Horizontal stress ratio.

[ipSoilDCER] – Reference void ratio.

[ipSoilDCConductivity] – Conductivity.

[ipSoilDCSpecificHeat] – Specific heat.

[ipSoilDCFluidLevel] – Fluid level.

[ipSoilDCViscosity] – Viscous damping coefficient.

[ipSoilDCDampingRatio] – Damping ratio.
