# St7SetBrickMCDPMaterial

Sets the Mohr-Coulomb and Drucker-Prager material properties for the specified brick property. Note that these
properties correspond to the isotropic yield criterion; to set soil material properties with these yield criteria use
St7SetBrickSoilMCMaterial or St7SetBrickSoilDPMaterial.

long St7SetBrickMCDPMaterial(long uID, long PropNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.

PropNum
Brick property number.
Doubles[0..1]
[ipFrictionAngle] – Friction angle.
[ipCohesion] – Cohesion value.
