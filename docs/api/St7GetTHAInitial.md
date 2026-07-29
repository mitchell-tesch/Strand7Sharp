# St7GetTHAInitial

Returns the initial conditions file assigned for transient heat analysis.

long St7GetTHAInitial(long uID, char* FileName, long* CaseNum, long MaxStringLen)
Input Parameters
uID
Strand7 model file ID.
MaxStringLen
Maximum number of characters allocated for FileName.
Output Parameters
FileName
Full path and name for the initial conditions file.
CaseNum
Result case number within FileName to be used as the initial conditions.
