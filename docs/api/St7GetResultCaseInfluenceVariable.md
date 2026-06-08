# St7GetResultCaseInfluenceVariable

Returns the details of the response variable used to generate the specified result case in the load influence result
file currently open.

long St7GetResultCaseInfluenceVariable(long uID, long CaseNum, long* Integers)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Result case number.

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

Applicability

Applicable to stLoadInfluence.
