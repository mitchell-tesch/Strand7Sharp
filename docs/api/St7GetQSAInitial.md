# St7GetQSAInitial

Returns the initial conditions file assigned for quasi-static analysis.

long St7GetQSAInitial(long uID, char* FileName, long* CaseNum, long MaxStringLen)

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

Solver – Natural Frequency

Solver – Natural Frequency
