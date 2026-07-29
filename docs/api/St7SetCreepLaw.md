# St7SetCreepLaw

Sets the type of creep law assigned to the specified creep definition.

long St7SetCreepLaw(long uID, long CreepID, long CreepLaw)
Input Parameters
uID
Strand7 model file ID.
CreepID
Creep layout ID.
CreepLaw
One of clConcreteHyperbolic, clConcreteViscoChain, clConcreteUserDefined, clPrimaryPower,
clSecondaryPower, clPrimarySecondaryPower, clSecondaryHyperbolic, clSecondaryExponential,
clThetaProjection, clGenGraham, clGenBlackburn or clUserDefined.
