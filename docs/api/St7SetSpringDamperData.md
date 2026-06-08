# St7SetSpringDamperData

Sets the spring-damper element parameters for the specified beam property.

long St7SetSpringDamperData(long uID, long PropNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

Beam property number.

Doubles[0..6]

[ipSpringAxialStiff] – Axial stiffness.

[ipSpringLateralStiff] – Lateral stiffness.

[ipSpringTorsionStiff] – Torsional stiffness.

[ipSpringAxialDamp] – Axial damping.

Strand7 API Manual

[ipSpringLateralDamp] – Lateral damping.

[ipSpringTorsionDamp] – Torsional damping.

[ipSpringMass] – Element mass.
