# St7GetCreepConcreteUserTableData

Returns the data assigned to the user defined Strain vs Time concrete table for the specified creep law definition.

long St7GetCreepConcreteUserTableData(long uID, long CreepID, long TableID,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

CreepID

Creep layout ID.

TableID

User defined Strain vs Time table ID.

Creep Law Definitions

Output Parameters
Doubles[0..1]

[0] – Age at first loading value.

[1] – Stress value associated with Strain vs Time data.
