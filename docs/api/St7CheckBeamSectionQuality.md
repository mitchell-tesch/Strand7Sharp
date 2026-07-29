# St7CheckBeamSectionQuality

Checks the quality of the section discretisation in response to unit shear forces and torque. Values closer to 1.0
are more accurate. Section quality discretisation is applicable to MNL solves.

long St7CheckBeamSectionQuality(long uID, long PropNum, double* Shear1,
double* Shear2, double* Torque)
Input Parameters
uID
Strand7 model file ID.
PropNum
Beam property number.
Output Parameters
Shear1
Unit shear 1 response.
Shear2
Unit shear 2 response.

Torque
Unit torque response.
