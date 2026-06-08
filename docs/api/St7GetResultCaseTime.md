# St7GetResultCaseTime

Returns the integration time for the specified result case in the result file currently open.

long St7GetResultCaseTime(long uID, long CaseNum, double* Time)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Result case number.

Output Parameters

Time

Integration time.

Applicability

Applicable to stQuasiStatic, stHarmonicResponse, stLinearTransientDynamic, stNonlinearTransientDynamic
and stTransientHeat.
