# St7SetCreepConcreteLoadingTimeUnit

Sets the time units for the specified concrete creep law definition.

long St7SetCreepConcreteLoadingTimeUnit(long uID, long CreepID, long* Integers)
Input Parameters
uID
Strand7 model file ID.
CreepID
Creep layout ID.
Integers[0..0]
[0] – Time units; one of tuMilliSec, tuSec, tuMin, tuHour or tuDay.
