# St7SetCreepUserTableData

Sets the data associated with the user defined Strain vs Time data for the specified creep law definition.

long St7SetCreepUserTableData(long uID, long CreepID, long TableID,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

CreepID

Creep layout ID.

TableID

User defined table ID.

Doubles[0..1]

[0] – Stress level associated with Strain vs Time data.

[1] – Temperature associated with Strain vs Time data.

Strand7 API Manual
