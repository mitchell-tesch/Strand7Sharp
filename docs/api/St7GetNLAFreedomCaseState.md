# St7GetNLAFreedomCaseState

Returns the enabled state of the specified freedom case for nonlinear static analysis.

long St7GetNLAFreedomCaseState(long uID, long Stage, long CaseNum, bool* Enabled)
Input Parameters
uID
Strand7 model file ID.
Stage
Stage index – use 0 for unstaged analysis.
CaseNum
Freedom case number.
Output Parameters
Enabled
True if the specified freedom case is enabled for nonlinear static analysis.
