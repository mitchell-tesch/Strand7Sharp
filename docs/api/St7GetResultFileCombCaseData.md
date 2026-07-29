# St7GetResultFileCombCaseData

Returns the combination data assigned to a combined result case in the specified result file combination.

long St7GetResultFileCombCaseData(long uID, long FileNum, long Pos,
long* CaseNum, double* Factor)
Input Parameters
uID
Strand7 model file ID.
FileNum
Combination file number.
Pos
Result case in combined file.
Output Parameters
CaseNum
Result case.
Factor
Combination factor.
