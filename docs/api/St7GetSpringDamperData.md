# St7GetSpringDamperData

Returns the spring-damper element parameters assigned to the specified beam property.

long St7GetSpringDamperData(long uID, long PropNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Beam property number.
Output Parameters
Doubles[0..6]
[ipSpringAxialStiff] – Axial stiffness.
[ipSpringLateralStiff] – Lateral stiffness.
[ipSpringTorsionStiff] – Torsional stiffness.
[ipSpringAxialDamp] – Axial damping.
[ipSpringLateralDamp] – Lateral damping.
[ipSpringTorsionDamp] – Torsional damping.
[ipSpringMass] – Element mass.
