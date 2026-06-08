# St7SetPlateUserDefinedMaterial

Sets the user defined material properties for the specified plate property.

long St7SetPlateUserDefinedMaterial(long uID, long PropNum, long MatType,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

Plate property number.

MatType

Matrix type; either mtStiffness or mtCompliance.

Doubles[0..35]

[0..20] – Material membrane, bending and coupling matrices with indexing as defined in User
Defined Material Matrix.

[ipPlateUserTransShearxz] – Transverse shear modulus G13.

Strand7 API Manual

[ipPlateUserTransShearyz] – Transverse shear modulus G23.

[ipPlateUserTransShearcz] – Transverse shear coupling modulus Gc3.

[ipPlateUserDensity] – Mass density per unit volume.

[ipPlateUserAlphax] – Thermal expansion coefficient in the 1 axis direction.

[ipPlateUserAlphay] – Thermal expansion coefficient in the 2 axis direction.

[ipPlateUserAlphaxy] – Thermal expansion coefficient in the 12 axis direction.

[ipPlateUserBetax] – Thermal curvature expansion coefficient along the 1 axis direction.

[ipPlateUserBetay] – Thermal curvature expansion coefficient along the 2 axis direction.

[ipPlateUserBetaxy] – Thermal twist expansion coefficient.

[ipPlateUserViscosity] – Viscous damping coefficient.

[ipPlateUserDampingRatio] – Damping ratio.

[ipPlateUserConductivity1] – Conductivity coefficient in the 1 axis direction.

[ipPlateUserConductivity2] – Conductivity coefficient in the 2 axis direction.

[ipPlateUserSpecificHeat] – Specific heat coefficient.
