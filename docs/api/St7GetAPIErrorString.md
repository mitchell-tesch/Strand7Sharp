# St7GetAPIErrorString

Returns the error message corresponding to the specified Strand7 API error code. Error codes corresponding to a
Strand7 solver error should be processed using St7GetSolverErrorString.

long St7GetAPIErrorString(long iErr, char* ErrorString, long MaxStringLen)
Input Parameters
iErr
Strand7 API error code.
MaxStringLen
Maximum number of characters allocated for ErrorString.
Output Parameters
ErrorString
Error message string corresponding to iErr.
