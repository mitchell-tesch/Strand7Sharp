# St7SetBrickAnisotropicMaterial

Sets the anisotropic material properties for the specified brick property.

long St7SetBrickAnisotropicMaterial(long uID, long PropNum, long MatType,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Brick property number.
MatType
Matrix type; either mtStiffness or mtCompliance.
Doubles[0..33]
[0..20] – Complete anisotropic material stress-strain matrix D defined by the upper triangular matrix
of coefficients D where i < j and i varies quickest: D , D ,… D , D ,… D , respectively.
ij 11 12 22 23 66
[ipBrickAnisoDensity] – Mass density per unit volume.
[ipBrickAnisoAlpha1] – Thermal expansion coefficient in the 1 axis direction.
[ipBrickAnisoAlpha2] – Thermal expansion coefficient in the 2 axis direction.
[ipBrickAnisoAlpha3] – Thermal expansion coefficient in the 3 axis direction.
[ipBrickAnisoAlpha12] – Thermal expansion coefficient in the 12 axis direction.
[ipBrickAnisoAlpha23] – Thermal expansion coefficient in the 23 axis direction.
[ipBrickAnisoAlpha31] – Thermal expansion coefficient in the 31 axis direction.

[ipBrickAnisoViscosity] – Viscous damping coefficient.
[ipBrickAnisoDampingRatio] – Damping ratio.
[ipBrickAnisoConductivity1] – Conductivity coefficient in the 1 axis direction.
[ipBrickAnisoConductivity2] – Conductivity coefficient in the 2 axis direction.
[ipBrickAnisoConductivity3] – Conductivity coefficient in the 3 axis direction.
[ipBrickAnisoSpecificHeat] – Specific heat coefficient.
