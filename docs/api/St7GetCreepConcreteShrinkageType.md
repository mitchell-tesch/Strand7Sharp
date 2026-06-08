# St7GetCreepConcreteShrinkageType

Returns the shrinkage type assigned to the specified creep law definition.

long St7GetCreepConcreteShrinkageType(long uID, long CreepID,

long* ShrinkageType)

Input Parameters

uID

Strand7 model file ID.

CreepID

Creep layout ID.

Strand7 API Manual

Output Parameters
ShrinkageType

Either crCreepShrinkageTable or crCreepShrinkageFormula.
