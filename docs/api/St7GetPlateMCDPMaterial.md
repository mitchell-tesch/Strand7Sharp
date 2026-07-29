# St7GetPlateMCDPMaterial

Returns the material properties assigned to the specified Mohr-Coulomb or Drucker-Prager plate property. Note
that these properties correspond to the isotropic yield criterion; to get soil material properties with these yield
criteria use St7GetPlateSoilMCMaterial or St7GetPlateSoilDPMaterial.

long St7GetPlateMCDPMaterial(long uID, long PropNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Plate property number.
Output Parameters
Doubles[0..1]
[ipFrictionAngle] – Friction angle.
[ipCohesion] – Cohesion value.
