# St7SetPlateSoilCCMaterial

Sets the soil material properties for the specified Cam-Clay plate property.

long St7SetPlateSoilCCMaterial(long uID, long PropNum, long* Integers,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

Plate property number.

Integers[0..3]

[ipSoilCCUsePoisson] – Use Poisson’s ratio; either btTrue or btFalse.

[ipSoilCCDrainedState] – Drained state; either btTrue or btFalse.

[ipSoilCCUseOCR] – Overconsolidation; either btTrue or btFalse.

[ipSoilCCSetPropLevel] – btTrue to set fluid level to Property value; btFalse to set fluid level to
Stage/Global level.

Doubles[0..16]

[ipSoilCCCriticalStateLine] – Critical state line slope.

[ipSoilCCConsolidationLine] – Normal consolidation line slope.

[ipSoilCCSwellingLine] – Swelling line slope.

[ipSoilCCDensity] – Mass density per unit volume.

[ipSoilCCPoisson] – Poisson’s ratio.

[ipSoilCCModulusGa] – Shear modulus at point A.

[ipSoilCCModulusGb] – Shear modulus at point B.

[ipSoilCCHorizontalRatio] – Horizontal stress ratio.

[ipSoilCCER] – Reference void ratio.

[ipSoilCCPR] – Unit pressure ratio.

[ipSoilCCPC0] – Initial consolidation pressure.

[ipSoilCCOCR] – Overconsolidation ratio.

[ipSoilCCConductivity] – Conductivity.

[ipSoilCCSpecificHeat] – Specific heat.

[ipSoilCCFluidLevel] – Fluid level.

Strand7 API Manual

[ipSoilCCViscosity] – Viscous damping coefficient.

[ipSoilCCDampingRatio] – Damping ratio.
