# St7GetTransientLoadCaseState

Returns the enabled state of the specified load case for quasi-static and transient dynamic analysis.

long St7GetTransientLoadCaseState(long uID, long CaseNum, bool* Enabled)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Load case number.

Output Parameters

Enabled

True if the specified load case is enabled.

Solver – Quasi-static and Transient Dynamic
