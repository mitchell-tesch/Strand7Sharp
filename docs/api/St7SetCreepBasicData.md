# St7SetCreepBasicData

Sets the basic creep coefficients for the specified creep law definition.

long St7SetCreepBasicData(long uID, long CreepID, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

CreepID

Creep layout ID.

Strand7 API Manual

Doubles[0..15]

An array containing the basic creep coefficients. See Creep Definitions for additional information.
