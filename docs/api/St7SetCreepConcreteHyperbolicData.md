# St7SetCreepConcreteHyperbolicData

Sets the hyperbolic data for the specified creep law definition.

long St7SetCreepConcreteHyperbolicData(long uID, long CreepID, long* Integers,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
CreepID
Creep layout ID.

Integers[0..1]
[ipCreepHyperbolicTimeTable] – Factor vs Time table ID, or 0 for none.
[ipCreepHyperbolicConstModulus] – Constant Modulus flag; either btTrue or btFalse.
Doubles[0..3]
[ipCreepHyberbolicAlpha] – Hyperbolic law alpha parameter.
[ipCreepHyperbolicBeta] – Hyperbolic law beta parameter.
[ipCreepHyperbolicDelta] – Hyperbolic law delta parameter.
[ipCreepHyperbolicPhi] – Hyperbolic law phi parameter.
