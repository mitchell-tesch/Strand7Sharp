# St7GetCreepConcreteCementCuringData

Returns the cement curing data associated with the specified creep law definition.

long St7GetCreepConcreteCementCuringData(long uID, long CreepID, long* Integers,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
CreepID
Creep layout ID.
Output Parameters
Integers[0..2]
[ipCreepIncludeCuring] – Include curing effects; either btTrue or btFalse.
[ipCreepCuringTimeTable] – Factor vs Time table ID, or 0 for none.
[ipCreepCuringType] – Curing rate; one of crCementCuringRapid, crCementCuringNormal or
crCementCuringSlow.
Doubles[0..2]
[ipCreepCuringCT] – Curing CT parameter.
[ipCreepCuringTRef] – Curing T parameter.
REF
[ipCreepCuringT0] – Curing T parameter.
0
