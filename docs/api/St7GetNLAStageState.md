# St7GetNLAStageState

Returns the enabled state assigned to the specified stage for nonlinear static analysis.

long St7GetNLAStageState(long uID, long Stage, bool* Enabled)
Input Parameters
uID
Strand7 model file ID.
Stage
Stage index.
Output Parameters
Enabled
True if the specified stage is enabled.
