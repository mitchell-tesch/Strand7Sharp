# St7GetBrickMCDPMaterial

Returns the Mohr-Coulomb and Drucker-Prager material properties assigned to the specified brick property.  Note
that these properties correspond to the isotropic yield criterion; to get soil material properties with these yield
criteria use St7GetBrickSoilMCMaterial or St7GetBrickSoilDPMaterial.

long St7GetBrickMCDPMaterial(long uID, long PropNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

Brick property number.

Output Parameters
Doubles[0..1]

[ipFrictionAngle] – Friction angle.

[ipCohesion] – Cohesion value.
