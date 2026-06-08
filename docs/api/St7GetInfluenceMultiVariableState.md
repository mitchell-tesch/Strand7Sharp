# St7GetInfluenceMultiVariableState

Returns the enabled state of the specified variable within a multi-variable load influence combination case.

long St7GetInfluenceMultiVariableState(long uID, long MultiVariableID,

long MultiVariableCaseID, bool* Enabled)

Input Parameters

uID

Strand7 model file ID.

Strand7 API Manual

MultiVariableID

ID of the load influence variable.

MultiVariableCaseID

ID of the load influence multi-variable combination case.

Output Parameters

Enabled

True if the variable is enabled in the case.
