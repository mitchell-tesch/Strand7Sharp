# St7GetCreepUserTableData

Returns the data associated with the user defined Strain vs Time table assigned to the specified creep law
definition.

long St7GetCreepUserTableData(long uID, long CreepID, long TableID,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

CreepID

Creep layout ID.

TableID

User defined table ID.

Output Parameters
Doubles[0..1]

[0] – Stress level associated with Strain vs Time data.

[1] – Temperature associated with Strain vs Time data.
