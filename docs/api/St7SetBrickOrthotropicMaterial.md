# St7SetBrickOrthotropicMaterial

Sets the orthotropic material properties for the specified brick property.

long St7SetBrickOrthotropicMaterial(long uID, long PropNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

Brick property number.

Doubles[0..18]

[ipBrickOrthoModulus1] – Modulus in the 1 axis direction.

[ipBrickOrthoModulus2] – Modulus in the 2 axis direction.

[ipBrickOrthoModulus3] – Modulus in the 3 axis direction.

[ipBrickOrthoShear12] – Shear modulus in the 12 axis direction.

[ipBrickOrthoShear23] – Shear modulus in the 23 axis direction.

[ipBrickOrthoShear31] – Shear modulus in the 31 axis direction.

Strand7 API Manual

[ipBrickOrthoPoisson12] – Poisson’s ratio in the 12 axis direction.

[ipBrickOrthoPoisson23] – Poisson’s ratio in the 23 axis direction.

[ipBrickOrthoPoisson31] – Poisson’s ratio in the 31 axis direction.

[ipBrickOrthoDensity] – Mass density per unit volume.

[ipBrickOrthoAlpha1] – Thermal expansion coefficient in the 1 axis direction.

[ipBrickOrthoAlpha2] – Thermal expansion coefficient in the 2 axis direction.

[ipBrickOrthoAlpha3] – Thermal expansion coefficient in the 3 axis direction.

[ipBrickOrthoViscosity] – Viscous damping coefficient.

[ipBrickOrthoDampingRatio] – Damping ratio.

[ipBrickOrthoConductivity1] – Conductivity coefficient in the 1 axis direction.

[ipBrickOrthoConductivity2] – Conductivity coefficient in the 2 axis direction.

[ipBrickOrthoConductivity3] – Conductivity coefficient in the 3 axis direction.

[ipBrickOrthoSpecificHeat] – Specific heat coefficient.
