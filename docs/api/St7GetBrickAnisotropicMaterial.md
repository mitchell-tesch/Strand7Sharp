# St7GetBrickAnisotropicMaterial

Returns the anisotropic material properties assigned to the specified brick property.

long St7GetBrickAnisotropicMaterial(long uID, long PropNum, long* MatType,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

Brick property number.

Output Parameters

MatType

Matrix type; either mtStiffness or mtCompliance.

Doubles[0..33]

[0..20] – Complete anisotropic material stress-strain matrix D defined by the upper triangular matrix
of coefficients Dij where i < j and i varies quickest: D11, D12,… D22, D23,… D66, respectively.

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

Properties – Beams, Plates and Bricks

[ipBrickAnisoConductivity3] – Conductivity coefficient in the 3 axis direction.

[ipBrickAnisoSpecificHeat] – Specific heat coefficient.
