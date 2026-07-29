# St7GetLIALoadCaseState

Returns the enabled state assigned to the specified load and freedom case combination for load influence
analysis.

long St7GetLIALoadCaseState(long uID, long LoadCaseNum, long FreedomCaseNum,
bool* Enabled)
Input Parameters
uID
Strand7 model file ID.

LoadCaseNum
Load case number.
FreedomCaseNum
Freedom case number.
Output Parameters
Enabled
True if the specified load and freedom case combination is enabled for load influence analysis.

Solver – Nonlinear Static
