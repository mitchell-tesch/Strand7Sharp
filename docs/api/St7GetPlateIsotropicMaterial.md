# St7GetPlateIsotropicMaterial

Returns the isotropic material properties for the specified plate property.

long St7GetPlateIsotropicMaterial(long uID, long PropNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Plate property number.
Output Parameters
Doubles[0..7]
[ipPlateIsoModulus] – Modulus.
[ipPlateIsoPoisson] – Poisson’s ratio.
[ipPlateIsoDensity] – Density.
[ipPlateIsoAlpha] – Thermal expansion coefficient.
[ipPlateIsoViscosity] – Viscous damping coefficient.
[ipPlateIsoDampingRatio] – Damping ratio.
[ipPlateIsoConductivity] – Conductivity coefficient.
[ipPlateIsoSpecificHeat] – Specific heat coefficient.
