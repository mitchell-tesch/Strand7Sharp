# St7GetNLAPseudoTimeState

Returns the enabled state of pseudo time for nonlinear static analysis.

long St7GetNLAPseudoTimeState(long uID, long Stage, bool* Enabled)
Input Parameters
uID
Strand7 model file ID.
Stage
Stage index – use 0 for unstaged analysis.
Output Parameters
Enabled
True if pseudo time is enabled.
