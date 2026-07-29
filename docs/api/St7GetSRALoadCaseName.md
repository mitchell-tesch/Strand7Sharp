# St7GetSRALoadCaseName

Returns the name of the specified Spectral Response analysis Load Excitation case.

long St7GetSRALoadCaseName(long uID, long SRACase, char* CaseName, long
MaxStringLen)
Input Parameters
uID
Strand7 model file ID.
SRACase
Spectral Response load excitation case number.

MaxStringLen
Maximum number of characters allocated for CaseName.
Output Parameters
CaseName
String containing the name of the load excitation case.
