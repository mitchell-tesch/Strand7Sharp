# St7SetPlyMaterial

Sets the material properties for the specified ply property.

long St7SetPlyMaterial(long uID, long PropNum, long* Integers, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Ply property number.
Integers[0..0]
[ipPlyWeaveType] – Weave type; one of wtPlyUniDirectional, wtPlyBiDirectional, wtPlyTriDirectional
or wtPlyQuasiIsotropic.
Doubles[0..20]
[ipPlyModulus1] – Modulus in the 1 axis direction.
[ipPlyModulus2] – Modulus in the 2 axis direction.
[ipPlyPoisson] – Poisson’s ratio.
[ipPlyShear12] – Shear modulus in the 12 axis direction.
[ipPlyShear13] – Shear modulus in the 13 axis direction.
[ipPlyShear23] – Shear modulus in the 23 axis direction.
[ipPlyAlpha1] – Thermal expansion coefficient in the 1 axis direction.
[ipPlyAlpha2] – Thermal expansion coefficient in the 2 axis direction.

[ipPlyDensity] – Mass density per unit volume.
[ipPlyThickness] – Thickness.
[ipPlyS1Tension] – Tensile stress limit in the 1 axis direction.
[ipPlyS2Tension] – Tensile stress limit in the 2 axis direction.
[ipPlyS1Compression] – Compressive stress limit in the 1 axis direction.
[ipPlyS2Compression] – Compressive stress limit in the 2 axis direction.
[ipPlySShear] – Shear stress limit.
[ipPlyE1Tension] – Tensile strain limit in the 1 axis direction.
[ipPlyE2Tension] – Tensile strain limit in the 2 axis direction.
[ipPlyE1Compression] – Compressive strain limit in the 1 axis direction.
[ipPlyE2Compression] – Compressive strain limit in the 2 axis direction.
[ipPlyEShear] – Shear strain limit.
[ipPlyInterLaminaShear] – Interlamina shear stress limit.
