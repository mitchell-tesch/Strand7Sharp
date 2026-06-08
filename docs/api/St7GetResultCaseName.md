# St7GetResultCaseName

Returns the name of the specified result case in the result file currently open.

long St7GetResultCaseName(long uID, long CaseNum, char* CaseName,

long MaxStringLen)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Result case number.

MaxStringLen

Maximum number of characters allocated for CaseName.

Results

Output Parameters
CaseName

Result case name.

Applicability

Applicable to all solver types.
