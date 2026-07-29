# St7SetCreepConcreteTemperatureData

Sets the concrete temperature data for the specified creep law definition.

long St7SetCreepConcreteTemperatureData(long uID, long CreepID, long* Integers,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
CreepID
Creep layout ID.
Integers[0..2]
[ipIncludeCreepTemperature] – Include temperature effects for the creep ageing; either btTrue
or btFalse.
[ipIncludeRateTemperature] – Include temperature effects for the creep rate; either btTrue or
btFalse.
[ipIncludeShrinkageTemperature] – Included temperature effects for the shrinkage ageing;
either btTrue or btFalse.
Doubles[0..5]
[ipCreepCAAge] – Creep age CA parameter.
[ipCreepTRefAge] – Creep age TA parameter.
REF
[ipCreepCCCreep] – Creep rate CC parameter.
[ipCreepTRefCreep] – Creep rate TC parameter.
REF
[ipCreepCAShrink] – Shrinkage age CA parameter.
[ipCreepTRefShrink] – Shrinkage age TA parameter.
REF
