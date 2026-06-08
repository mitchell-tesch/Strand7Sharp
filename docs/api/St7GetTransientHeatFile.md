# St7GetTransientHeatFile

Returns the temperature file assigned for quasi-static and nonlinear transient dynamic analysis.

long St7GetTransientHeatFile(long uID, char* FileName, long MaxStringLen,

double* RefTemp)

Input Parameters

uID

Strand7 model file ID.

MaxStringLen

Maximum number of characters allocated for FileName.

Output Parameters
FileName

Full path and name for the temperature file.

RefTemp

Reference temperature.
