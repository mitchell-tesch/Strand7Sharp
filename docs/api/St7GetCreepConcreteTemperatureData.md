# St7GetCreepConcreteTemperatureData

Returns the concrete temperature data associated with the specified creep law definition.

long St7GetCreepConcreteTemperatureData(long uID, long CreepID, long* Integers,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

CreepID

Creep layout ID.

Output Parameters

Integers[0..2]

[ipIncludeCreepTemperature] – Include temperature effects for the creep ageing; either btTrue
or btFalse.

Creep Law Definitions

[ipIncludeRateTemperature] – Include temperature effects for the creep rate; either btTrue or
btFalse.

[ipIncludeShrinkageTemperature] – Include temperature effects for the shrinkage ageing; either
btTrue or btFalse.

Doubles[0..5]

[ipCreepCAAge] – Creep age CA parameter.

[ipCreepTRefAge] – Creep age TAREF parameter.

[ipCreepCCCreep] – Creep rate CC parameter.

[ipCreepTRefCreep] – Creep rate TCREF parameter.

[ipCreepCAShrink] – Shrinkage age CA parameter.

[ipCreepTRefShrink] – Shrinkage age TAREF parameter.
