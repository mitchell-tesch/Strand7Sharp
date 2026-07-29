# St7GetNLALoadCaseState

Returns the enabled state assigned to the specified load case for nonlinear static analysis.

long St7GetNLALoadCaseState(long uID, long Stage, long CaseNum, bool* Enabled)
Input Parameters
uID
Strand7 model file ID.
Stage
Stage index – use 0 for unstaged analysis.
CaseNum
Load case number.
Output Parameters
Enabled
True if the specified load case is enabled for nonlinear static analysis.
