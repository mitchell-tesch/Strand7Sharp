# St7GetCreepHardeningType

Returns the hardening type assigned to the specified creep law definition.

long St7GetCreepHardeningType(long uID, long CreepID, long* Integers)
Input Parameters
uID
Strand7 model file ID.
CreepID
Creep layout ID.
Output Parameters
Integers[0..1]
[ipCreepHardeningType] – Type of creep hardening; either crHardeningTime or crHardeningStrain.
[ipCreepHardeningCyclic] – Cyclic hardening option; either btTrue or btFalse.
