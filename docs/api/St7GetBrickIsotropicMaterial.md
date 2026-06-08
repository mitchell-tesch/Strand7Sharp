# St7GetBrickIsotropicMaterial

Returns the isotropic material properties assigned to the specified brick property.

Properties – Beams, Plates and Bricks

long St7GetBrickIsotropicMaterial(long uID, long PropNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

Brick property number.

Output Parameters
Doubles[0..7]

[ipBrickIsoModulus] – Modulus.

[ipBrickIsoPoisson] – Poisson’s ratio.

[ipBrickIsoDensity] – Mass density per unit volume.

[ipBrickIsoAlpha] – Thermal expansion coefficient.

[ipBrickIsoViscosity] – Viscous damping coefficient.

[ipBrickIsoDampingRatio] – Damping ratio.

[ipBrickIsoConductivity] – Conductivity coefficient.

[ipBrickIsoSpecificHeat] – Specific heat coefficient.
