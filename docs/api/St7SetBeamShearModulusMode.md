# St7SetBeamShearModulusMode

Sets the specified beam property to use either Poisson’s ratio or shear modulus for defining the material matrix.

long St7SetBeamShearModulusMode(long uID, long PropNum, long Mode)
Input Parameters
uID
Strand7 model file ID.
PropNum
Beam property number.
Mode
Either smUsePoissonsRatio or smUseShearModulus.
Usage
If Mode=smUsePoissonsRatio, the shear modulus is calculated from Young’s modulus and Poisson’s ratio
assuming an isotropic material. If Mode=smUseShearModulus, the shear modulus is used directly.
