# St7SetCreepConcreteUserTableData

Sets the data for the user defined concrete Strain vs Time table for the specified creep law definition.

long St7SetCreepConcreteUserTableData(long uID, long CreepID, long TableID,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
CreepID
Creep layout ID.
TableID
User defined Strain vs Time table ID.
Doubles[0..1]
[0] – Age at first loading value.
[1] – Stress value associated with Strain vs Time data.
