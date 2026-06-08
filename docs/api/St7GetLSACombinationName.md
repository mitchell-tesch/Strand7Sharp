# St7GetLSACombinationName

Returns the name of the specified linear load case combination for solver-generated .LSA files.

Strand7 API Manual

long St7GetLSACombinationName(long uID, long CaseNum, char* CaseName,

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
