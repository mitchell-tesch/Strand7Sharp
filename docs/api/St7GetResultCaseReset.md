# St7GetResultCaseReset

Checks to see if the model has been reset for the specified result case in the result file currently open.

long St7GetResultCaseReset(long uID, long CaseNum, bool* Reset)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Result case number.

Output Parameters

Reset

btTrue if RESET MODEL has been enabled for the result case.

Applicability

Applicable to stNonlinearStatic.
