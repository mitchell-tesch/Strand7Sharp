# St7GetCreepConcreteUserTableState

Returns the enabled state of the user defined concrete Strain vs Time table for the specified creep law definition.

long St7GetCreepConcreteUserTableState(long uID, long CreepID, long TableID,

bool* Enabled)

Input Parameters

uID

Strand7 model file ID.

CreepID

Creep layout ID.

Strand7 API Manual

TableID

User defined Strain vs Time table ID.

Output Parameters

Enabled

True if the user defined concrete table is enabled.
