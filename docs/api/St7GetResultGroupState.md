# St7GetResultGroupState

Returns the enabled state of the group results for the analysis. Only element results corresponding to enabled
groups are written to the result file.

long St7GetResultGroupState(long uID, long GroupID, bool* Enabled)
Input Parameters
uID
Strand7 model file ID.
GroupID
Group ID.
Output Parameters
Enabled
True if the specified group is enabled.
