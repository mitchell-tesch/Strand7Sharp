# St7GetInfluenceMaxVariableState

Returns the enabled state of the specified single-variable maximum load influence combination.

long St7GetInfluenceMaxVariableState(long uID, long MaxVariableID, bool* Enabled)

Input Parameters

uID

Strand7 model file ID.

MaxVariableID

ID of the load influence variable.

Output Parameters

Enabled

True if the variable is enabled.
