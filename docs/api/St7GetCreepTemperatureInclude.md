# St7GetCreepTemperatureInclude

Returns the temperature dependency for the specified creep law definition, where applicable.

long St7GetCreepTemperatureInclude(long uID, long CreepID, bool* Include)
Input Parameters
uID
Strand7 model file ID.
CreepID
Creep layout ID.
Output Parameters
Include
Returns True when temperature dependent terms are included.
