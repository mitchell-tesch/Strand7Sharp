# St7GetCreepConcreteFunctionType

Returns the concrete type assigned to the specified creep law definition.

long St7GetCreepConcreteFunctionType(long uID, long CreepID, long* FunctionType)

Input Parameters

uID

Strand7 model file ID.

CreepID

Creep layout ID.

Output Parameters
FunctionType

Either crCreepFunction or crRelaxationFunction.
