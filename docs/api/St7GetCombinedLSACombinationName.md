# St7GetCombinedLSACombinationName

Returns the name of the specified linear load case combination for user-generated .LSA files.

long St7GetCombinedLSACombinationName(long uID, long CaseNum, char* CaseName,

long MaxStringLen)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Load case combination number.

MaxStringLen

Maximum number of characters allocated for CaseName.

Output Parameters
CaseName

Name of the specified load case combination.
