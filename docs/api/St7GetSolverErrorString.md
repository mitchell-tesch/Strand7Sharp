# St7GetSolverErrorString

Returns the error message corresponding to the specified Strand7 solver error code. Error codes corresponding to
a Strand7 API error should be processed using St7GetAPIErrorString.

long St7GetSolverErrorString(long iErr, char* ErrorString, long MaxStringLen)

Input Parameters

iErr

Strand7 solver error code.

MaxStringLen

Maximum number of characters allocated for ErrorString.

Initialisation

Output Parameters
ErrorString

Error message string corresponding to iErr.
