# St7SetPlateLaminateMaterial

Sets the laminate material properties for the specified plate property. Not all parameters returned by
St7GetPlateLaminateMaterial can be set, as some parameters are based on the ply properties in the layup.

long St7SetPlateLaminateMaterial(long uID, long PropNum, long LaminateID,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Plate property number.
LaminateID
Laminate layout ID.
Doubles[0..4]
[ipLaminateViscosity] – Viscous damping coefficient.
[ipLaminateDampingRatio] – Damping ratio.
[ipLaminateConductivity1] – Conductivity coefficient in the x axis direction.
[ipLaminateConductivity2] – Conductivity coefficient in the y axis direction.
[ipLaminateSpecificHeat] – Specific heat coefficient.
