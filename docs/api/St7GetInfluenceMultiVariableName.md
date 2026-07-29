# St7GetInfluenceMultiVariableName

Returns the name of a multi-variable load influence combination case.

long St7GetInfluenceMultiVariableName(long uID, long MultiVariableCaseID,
char* MultiVariableName, long MaxStringLen)
Input Parameters
uID
Strand7 model file ID.
MultiVariableCaseID
ID of the load influence multi-variable combination case.
MaxStringLen
The maximum number of characters allocated for MultiVariableName.
Output Parameters
MultiVariableName
Name of the load influence multi-variable combination case.
