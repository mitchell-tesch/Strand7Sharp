# St7GetNSMassCaseInMassMatrixState

Returns whether non-structural mass in the specified load case is enabled for inclusion in the mass matrix for
natural frequency and transient dynamic analysis.

long St7GetNSMassCaseInMassMatrixState(long uID, long CaseNum, bool* Enabled)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Load case number.

Output Parameters

Enabled

True if the non-structural mass is enabled for the specified load case.

Solver – Time Stepping

Solver – Time Stepping

These functions apply to transient dynamic, quasi-static and transient heat analysis.
