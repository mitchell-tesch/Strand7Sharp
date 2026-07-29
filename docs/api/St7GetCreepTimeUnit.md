# St7GetCreepTimeUnit

Returns the time units for the specified metallic creep law definition.

long St7GetCreepTimeUnit(long uID, long CreepID, long* Integers)
Input Parameters
uID
Strand7 model file ID.
CreepID
Creep layout ID.
Output Parameters
Integers[0..0]
[0] – Time units; one of tuMilliSec, tuSec, tuMin, tuHour or tuDay.
