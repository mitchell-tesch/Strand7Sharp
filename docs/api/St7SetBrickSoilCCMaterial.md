# St7SetBrickSoilCCMaterial

Sets the Cam-Clay soil material properties for the specified brick property.

long St7SetBrickSoilCCMaterial(long uID, long PropNum, long* Integers,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Brick property number.
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
[ipSoilCCViscosity] – Viscous damping coefficient.
[ipSoilCCDampingRatio] – Damping ratio.
