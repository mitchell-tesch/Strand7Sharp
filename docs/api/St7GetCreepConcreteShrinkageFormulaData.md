# St7GetCreepConcreteShrinkageFormulaData

Returns the shrinkage formula data assigned to the specified creep law definition.

long St7GetCreepConcreteShrinkageFormulaData(long uID, long CreepID,

long* Integers, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

CreepID

Creep layout ID.

Output Parameters
Integers[0]

Currently unused.

Creep Law Definitions

Doubles[0..3]

[ipCreepShrinkageAlpha] – Concrete shrinkage alpha parameter.

[ipCreepShrinkageBeta] – Concrete shrinkage beta parameter.

[ipCreepShrinkageDelta] – Concrete shrinkage delta parameter.

[ipCreepShrinkageStrain] – Concrete shrinkage initial strain parameter.
