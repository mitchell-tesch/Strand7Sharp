# St7GetInfluenceVariable

Returns information about a load influence variable.

long St7GetInfluenceVariable(long uID, long VariableID, long* Integers)

Input Parameters

uID

Strand7 model file ID.

VariableID

Load influence variable number.

Output Parameters

Integers[0..6]

[ipLIAVarLoadCaseNum] – Load case in which the response variable is defined.

[ipLIAVarFreedomCaseNum] – Freedom case used for the influence analysis.

[ipLIAVarEntity] – Entity type; one of tyNODE, tyBEAM, tyPLATE or tyBRICK.

[ipLIAVarEntityNum] – Entity number.

[ipLIAVarUCSId] – ID number of the UCS, if relevant.

[ipLIAVarType] – For tyNODE, either rvNodeDisplacement or rvNodeReaction. For tyBEAM, the
beam end. For tyPLATE, either rvPlateForce or rvPlateMoment. Not relevant for tyBRICK.

[ipLIAVarComponent] – The degree of freedom or axis direction of the response variable.
