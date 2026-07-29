# St7GetResultFileCombCaseName

Returns the name assigned to a combined result case in the specified result file combination.

long St7GetResultFileCombCaseName(long uID, long Pos, char* CaseName,
long MaxStringLen)
Input Parameters
uID
Strand7 model file ID.
Pos
Result case in combined file.
MaxStringLen
Maximum number of characters allocated for CaseName.
Output Parameters
CaseName
Combined result case name.
