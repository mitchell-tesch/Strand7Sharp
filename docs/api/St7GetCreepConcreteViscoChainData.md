# St7GetCreepConcreteViscoChainData

Returns the visco-elastic chain data assigned to the specified creep law definition.

long St7GetCreepConcreteViscoChainData(long uID, long CreepID, long Pos,

long* Integers, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

CreepID

Creep layout ID.

Pos

Chain number.

Output Parameters

Integers[0..1]

[ipCreepViscoTimeTable] – Strain vs Time table ID, or 0 for none.

[ipCreepViscoTempTable] – Factor vs Temperature table ID, or 0 for none.

Doubles[0..1]

[ipCreepViscoDamper] – Damping value.

Creep Law Definitions

[ipCreepViscoStiffness] – Stiffness value.
