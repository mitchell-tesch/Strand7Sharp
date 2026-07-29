# St7GetResultFileCombFileName

Returns the name of the specified file in the current results file combination.

long St7GetResultFileCombFileName(long uID, long FileNum, char* FileName,
long MaxStringLen)
Input Parameters
uID
Strand7 model file ID.
FileNum
File number in the current combination.
MaxStringLen
Maximum number of characters allocated for FileName.

Output Parameters
FileName
Full path and name for the file.
