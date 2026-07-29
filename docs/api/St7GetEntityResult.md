# St7GetEntityResult

Returns the enabled state for the specified entity result. Only enabled entity results are written to the result file.

long St7GetEntityResult(long uID, long Result, bool* Enabled)
Input Parameters
uID
Strand7 model file ID.
Result
See Solver Options for additional information.
Output Parameters
Enabled
Either True or False.
