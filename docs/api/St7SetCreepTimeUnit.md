# St7SetCreepTimeUnit

Sets the time units for the specified metallic creep law definition.

long St7SetCreepTimeUnit(long uID, long CreepID, long* Integers)

Input Parameters

uID

Strand7 model file ID.

CreepID

Creep layout ID.

Integers[0..0]

[0] – Time units; one of tuMilliSec, tuSec, tuMin, tuHour or tuDay.
