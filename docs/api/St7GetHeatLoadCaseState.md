# St7GetHeatLoadCaseState

Returns the enabled state of the specified load case for steady heat and transient heat analysis.

long St7GetHeatLoadCaseState(long uID, long CaseNum, bool* Enabled)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Load case number.

Output Parameters

Enabled

True if the specified load case is enabled for steady heat or transient heat analysis.

Solver – Steady Heat and Transient Heat
