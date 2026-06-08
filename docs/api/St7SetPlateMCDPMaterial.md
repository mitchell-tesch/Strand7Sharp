# St7SetPlateMCDPMaterial

Sets the material properties for the specified Mohr-Coulomb or Drucker-Prager plate property. Note that these
properties correspond to the isotropic yield criterion; to set soil material properties with these yield criteria use
St7SetPlateSoilMCMaterial or  St7SetPlateSoilDPMaterial.

long St7SetPlateMCDPMaterial(long uID, long PropNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

Plate property number.

Doubles[0..1]

[ipFrictionAngle] – Friction angle.

[ipCohesion] – Cohesion value.
