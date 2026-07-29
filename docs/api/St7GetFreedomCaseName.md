# St7GetFreedomCaseName

Returns the name of the specified freedom case in a Strand7 model.

long St7GetFreedomCaseName(long uID, long CaseNum, char* CaseName,
long MaxStringLen)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Freedom case number.

MaxStringLen
The maximum number of characters allocated for CaseName.
Output Parameters
CaseName
String containing the name of the specified freedom case.
