# St7GetCreepUserTableState

Returns the enabled state of a user defined Strain vs Time table for the specified creep law definition.

long St7GetCreepUserTableState(long uID, long CreepID, long TableID,
bool* Enabled)
Input Parameters
uID
Strand7 model file ID.
CreepID
Creep layout ID.
TableID
User defined Strain vs Time table ID.
Output Parameters
Enabled
True if the user defined table is enabled.
