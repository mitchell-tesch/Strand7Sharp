# St7GetLSALoadCaseState

Returns the enabled state of the specified load case and freedom case combination for linear static analysis.

long St7GetLSALoadCaseState(long uID, long LoadCaseNum, long FreedomCaseNum,
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
True if the specified load/seismic case and freedom case combination is enabled for linear static
analysis.
