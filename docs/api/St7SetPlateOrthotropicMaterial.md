# St7SetPlateOrthotropicMaterial

Sets the orthotropic material properties for the specified plate property.

long St7SetPlateOrthotropicMaterial(long uID, long PropNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Plate property number.
Doubles[0..17]
[ipPlateOrthoModulus1] – Modulus in the 1 axis direction.

[ipPlateOrthoModulus2] – Modulus in the 2 axis direction.
[ipPlateOrthoModulus3] – Modulus in the 3 axis direction.
[ipPlateOrthoShear12] – Shear modulus in the 12 axis direction.
[ipPlateOrthoShear23] – Shear modulus in the 23 axis direction.
[ipPlateOrthoShear31] – Shear modulus in the 31 axis direction.
[ipPlateOrthoPoisson12] – Poisson’s ratio in the 12 axis direction.
[ipPlateOrthoPoisson23] – Poisson’s ratio in the 23 axis direction.
[ipPlateOrthoPoisson31] – Poisson’s ratio in the 31 axis direction.
[ipPlateOrthoDensity] – Density.
[ipPlateOrthoAlpha1] – Thermal expansion coefficient in the 12 axis direction.
[ipPlateOrthoAlpha2] – Thermal expansion coefficient in the 23 axis direction.
[ipPlateOrthoAlpha3] – Thermal expansion coefficient in the 31 axis direction.
[ipPlateOrthoViscosity] – Viscous damping coefficient.
[ipPlateOrthoDampingRatio] – Damping ratio.
[ipPlateOrthoConductivity1] – Thermal conductivity in the 1 axis direction.
[ipPlateOrthoConductivity2] – Thermal conductivity in the 2 axis direction.
[ipPlateOrthoSpecificHeat] – Specific heat coefficient.
