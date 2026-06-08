# St7SetPlateIsotropicMaterial

Sets the isotropic material parameters for the specified plate property.

long St7SetPlateIsotropicMaterial(long uID, long PropNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

Plate property number.

Doubles[0..7]

[ipPlateIsoModulus] – Modulus.

[ipPlateIsoPoisson] – Poisson’s ratio.

[ipPlateIsoDensity] – Density.

[ipPlateIsoAlpha] – Thermal expansion coefficient.

[ipPlateIsoViscosity] – Viscous damping coefficient.

Strand7 API Manual

[ipPlateIsoDampingRatio] – Damping ratio.

[ipPlateIsoConductivity] – Conductivity coefficient.

[ipPlateIsoSpecificHeat] – Specific heat coefficient.
