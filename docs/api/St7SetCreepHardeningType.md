# St7SetCreepHardeningType

Sets the hardening type for the specified creep law definition.

long St7SetCreepHardeningType(long uID, long CreepID, long* Integers)
Input Parameters
uID
Strand7 model file ID.
CreepID
Creep layout ID.
Integers[0..1]
[ipCreepHardeningType] – Type of creep hardening; either crHardeningTime or crHardeningStrain.
[ipCreepHardeningCyclic] – Cyclic hardening option; either btTrue or btFalse.
