# St7SetCreepConcreteShrinkageFormulaData

Assigns the shrinkage formula data for the specified creep law definition.

long St7SetCreepConcreteShrinkageFormulaData(long uID, long CreepID,

long* Integers, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

CreepID

Creep layout ID.

Integers[0]

Currently unused.

Doubles[0..3]

[ipCreepShrinkageAlpha] – Concrete shrinkage alpha parameter.

[ipCreepShrinkageBeta] – Concrete shrinkage beta parameter.

[ipCreepShrinkageDelta] – Concrete shrinkage delta parameter.

[ipCreepShrinkageStrain] – Concrete shrinkage initial strain parameter.
