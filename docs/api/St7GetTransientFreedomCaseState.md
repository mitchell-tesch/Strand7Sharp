# St7GetTransientFreedomCaseState

Returns the enabled state of the specified freedom case for quasi-static and transient dynamic analysis.

long St7GetTransientFreedomCaseState(long uID, long CaseNum, bool* Enabled)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Freedom case number.

Output Parameters

Enabled

True if the specified freedom case is enabled.
