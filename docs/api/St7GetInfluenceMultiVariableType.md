# St7GetInfluenceMultiVariableType

Returns the type of a multi-variable load influence combination case.

long St7GetInfluenceMultiVariableType(long uID, long MultiVariableCaseID,
long* MultiVariableType)
Input Parameters
uID
Strand7 model file ID.
MultiVariableCaseID
ID of the load influence multi-variable combination case.
Output Parameters
MultiVariableType
Either icInfluenceMin or icInfluenceMax.
