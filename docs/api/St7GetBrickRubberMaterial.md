# St7GetBrickRubberMaterial

Returns the rubber material properties assigned to the specified brick property.

Strand7 API Manual

long St7GetBrickRubberMaterial(long uID, long PropNum, long* RubberType,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

Brick property number.

Output Parameters
RubberType

One of rtNeoHookean, rtMooneyRivlin or rtGeneralisedMooneyRivlin.

Doubles[0..15]

An array describing the rubber material coefficients. The format depends on the material sub-type, with
different sub-types requiring a varying number of rubber coefficients following the common data:

[ipRubberBulk] – Bulk modulus.

[ipRubberDensity] – Mass density per unit volume.

[ipRubberAlpha] – Thermal expansion coefficient.

[ipRubberViscosity] – Viscous damping coefficient.

[ipRubberDampingRatio] – Damping ratio.

[ipRubberConductivity] – Conductivity.

[ipRubberSpecificHeat] – Specific heat.

[ipRubberConstC1..ipRubberConstC1+Num] – Rubber coefficients,

where:
Num = 0 (Neo-Hookean)
Num = 1 (Mooney-Rivlin)
Num = 8 (Generalised Mooney-Rivlin)
