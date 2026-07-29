# St7GetLoadCaseName

Returns the name of the specified load case within a Strand7 model.

long St7GetLoadCaseName(long uID, long CaseNum, char* CaseName,
long MaxStringLen)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Load case number.
MaxStringLen
The maximum number of characters allocated for CaseName.
Output Parameters
CaseName
String containing the name of the specified load case.
