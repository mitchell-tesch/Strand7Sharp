# St7GetPlateLaminateMaterial

Returns the laminate material properties for the specified plate property.

long St7GetPlateLaminateMaterial(long uID, long PropNum, long* LaminateID,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Plate property number.
Output Parameters
LaminateID
Laminate layout ID.
Doubles[0..17]
[ipLaminateViscosity] – Viscous damping coefficient.

[ipLaminateDampingRatio] – Damping ratio.
[ipLaminateConductivity1] – Conductivity coefficient in the x axis direction.
[ipLaminateConductivity2] – Conductivity coefficient in the y axis direction.
[ipLaminateSpecificHeat] – Specific heat coefficient.
[ipLaminateDensity] – Mass density per unit volume.
[ipLaminateAlphax] – Effective membrane thermal expansion coefficient in the x axis direction.
[ipLaminateAlphay] – Effective membrane thermal expansion coefficient in the y axis direction.
[ipLaminateAlphaxy] – Effective membrane shear thermal expansion coefficient in the xy plane.
[ipLaminateBetax] – Effective bending thermal expansion coefficient in the x direction.
[ipLaminateBetay] – Effective bending thermal expansion coefficient in the y direction.
[ipLaminateBetaxy] – Effective twisting thermal expansion coefficient out of the xy plane.
[ipLaminateModulusx] – Effective modulus in the x axis direction.
[ipLaminateModulusy] – Effective modulus in the y axis direction.
[ipLaminateShearxy] – Effective shear modulus in the xy plane.
[ipLaminatePoissonxy] – Effective Poisson’s ratio v .
xy
[ipLaminatePoissonyx] – Effective Poisson’s ratio v .
yx
[ipLaminateThickness] – Thickness.
