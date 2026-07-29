# St7GetCreepLaw

Returns the type of creep law assigned to the specified creep definition.

long St7GetCreepLaw(long uID, long CreepID, long* CreepLaw)
Input Parameters
uID
Strand7 model file ID.
CreepID
Creep layout ID.
Output Parameters
CreepLaw
One of clConcreteHyperbolic, clConcreteViscoChain, clConcreteUserDefined, clPrimaryPower,
clSecondaryPower, clPrimarySecondaryPower, clSecondaryHyperbolic, clSecondaryExponential,
clThetaProjection, clGenGraham, clGenBlackburn or clUserDefined.
