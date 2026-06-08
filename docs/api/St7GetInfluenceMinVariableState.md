# St7GetInfluenceMinVariableState

Returns the enabled state of the specified single-variable minimum load influence combination.

long St7GetInfluenceMinVariableState(long uID, long MinVariableID, bool* Enabled)

Input Parameters

uID

Strand7 model file ID.

MinVariableID

ID of the load influence variable.

Output Parameters

Enabled

True if the variable is enabled.
