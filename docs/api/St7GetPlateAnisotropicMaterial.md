# St7GetPlateAnisotropicMaterial

Returns the anisotropic material properties assigned to the specified plate property.

long St7GetPlateAnisotropicMaterial(long uID, long PropNum, long* MatType,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Plate property number.
Output Parameters
MatType
Matrix type; either mtStiffness or mtCompliance.
Doubles[0..22]
[0..5] – In-plane components of the anisotropic material stress-strain matrix D defined by the
coefficients D , D , D , D , D and D , respectively.
11 12 13 22 23 33
[6..9] – Out-of-plane components of the anisotropic material stress-strain matrix D defined by the
coefficients D , D , D , and D , respectively (plane stress and plane strain elements only).
14 24 34 44
[ipPlateAnisoTransShear1] – Transverse shear modulus in the 13 plane.
[ipPlateAnisoTransShear2] – Transverse shear modulus in the 23 plane.
[ipPlateAnisoTransShear3] – Transverse shear coupling modulus.
[ipPlateAnisoDensity] – Density.
[ipPlateAnisoAlpha1] – Thermal expansion coefficient in the 1 axis direction.
[ipPlateAnisoAlpha2] – Thermal expansion coefficient in the 2 axis direction.
[ipPlateAnisoAlpha3] – Thermal expansion coefficient in the 3 axis direction.
[ipPlateAnisoAlpha12] – Thermal expansion coefficient in the 12 axis direction.
[ipPlateAnisoViscosity] – Viscous damping coefficient.
[ipPlateAnisoDampingRatio] – Damping ratio.
[ipPlateAnisoConductivity1] – Conductivity coefficient in the 1 axis direction.
[ipPlateAnisoConductivity2] – Conductivity coefficient in the 2 axis direction.
[ipPlateAnisoSpecificHeat] – Specific heat coefficient.
