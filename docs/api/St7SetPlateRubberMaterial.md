# St7SetPlateRubberMaterial

Sets the rubber material properties for the specified plate property.

long St7SetPlateRubberMaterial(long uID, long PropNum, long RubberType,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

Plate property number.

RubberType

One of rtNeoHookean, rtMooneyRivlin, rtGeneralisedMooneyRivlin or rtOgden.

Doubles[0..15]

An array describing the rubber material coefficients. The format depends on the material sub-type, with
different sub-types requiring a varying number of rubber coefficients following the common data:

[ipRubberBulk] – Bulk modulus.

[ipRubberDensity] – Density.

[ipRubberAlpha] – Thermal expansion coefficient.

[ipRubberViscosity] – Viscous damping coefficient.

Properties – Beams, Plates and Bricks

[ipRubberDampingRatio] – Damping ratio.

[ipRubberConductivity] – Conductivity.

[ipRubberSpecificHeat] – Specific heat.

[ipRubberConstC1..ipRubberConstC1+Num] – Rubber coefficients,

where:
Num = 0 (Neo-Hookean)
Num = 1 (Mooney-Rivlin)
Num = 8 (Generalised Mooney-Rivlin)
Num = 5 (Ogden)
