# St7SetInfluenceMultiVariableState

Set the enabled state of the specified variable within a multi-variable load influence combination case.

long St7SetInfluenceMultiVariableState(long uID, long MultiVariableID,

long MultiVariableCaseID, bool Enabled)

Input Parameters

uID

Strand7 model file ID.

MultiVariableID

ID of the load influence variable.

MultiVariableCaseID

ID of the load influence multi-variable combination case.

Enabled

True to enable the variable in the case.
