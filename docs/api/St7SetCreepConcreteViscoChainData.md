# St7SetCreepConcreteViscoChainData

Sets the visco-elastic chain data for the specified creep law definition.

Strand7 API Manual

long St7SetCreepConcreteViscoChainData(long uID, long CreepID, long Pos,

long* Integers, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

CreepID

Creep layout ID.

Pos

Chain number.

Integers[0..1]

[ipCreepViscoTimeTable] – Strain vs Time table ID, or 0 for none.

[ipCreepViscoTempTable] – Factor vs Temperature table ID, or 0 for none.

Doubles[0..1]

[ipCreepViscoDamper] – Damping value.

[ipCreepViscoStiffness] – Stiffness value.
