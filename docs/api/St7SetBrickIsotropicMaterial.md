# St7SetBrickIsotropicMaterial

Set the isotropic material properties for the specified brick property.

long St7SetBrickIsotropicMaterial(long uID, long PropNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

Brick property number.

Doubles[0..7]

[ipBrickIsoModulus] – Modulus.

[ipBrickIsoPoisson] – Poisson’s ratio.

[ipBrickIsoDensity] – Mass density per unit volume.

[ipBrickIsoAlpha] – Thermal expansion coefficient.

[ipBrickIsoViscosity] – Viscous damping coefficient.

[ipBrickIsoDampingRatio] – Damping ratio.

[ipBrickIsoConductivity] – Conductivity coefficient.

[ipBrickIsoSpecificHeat] – Specific heat coefficient.
