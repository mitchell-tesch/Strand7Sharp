# St7GetCreepBasicData

Returns the basic creep coefficients assigned to the specified creep definition.

long St7GetCreepBasicData(long uID, long CreepID, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

CreepID

Creep layout ID.

Output Parameters

Doubles[0..15]

An array containing the basic creep coefficients. See Creep Definitions for additional information.
