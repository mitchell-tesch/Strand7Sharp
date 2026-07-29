# St7GetSRABaseCaseName

Returns the name of the specified Spectral Response analysis Base Excitation case.

long St7GetSRABaseCaseName(long uID, long SRACase, char* CaseName,
long MaxStringLen)
Input Parameters
uID
Strand7 model file ID.

SRACase
Spectral Response base excitation case number.
MaxStringLen
Maximum number of characters allocated for CaseName.
Output Parameters
CaseName
String containing the name of the base excitation case.
