# St7GetSRABaseCaseType

Returns the modal load type for the specified Spectral Response analysis Base Excitation case.

long St7GetSRABaseCaseType(long uID, long SRACase, long* VectType)
Input Parameters
uID
Strand7 model file ID.
SRACase
Spectral Response base excitation case number.
Output Parameters
VectType
One of slBaseAcc, slBaseVel or slBaseDisp.
