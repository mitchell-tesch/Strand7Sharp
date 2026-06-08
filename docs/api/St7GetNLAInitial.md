# St7GetNLAInitial

Returns the initial conditions file assigned for nonlinear static analysis.

long St7GetNLAInitial(long uID, char* FileName, long* CaseNum, long MaxStringLen)

Input Parameters

uID

Strand7 model file ID.

MaxStringLen

Maximum number of characters allocated for FileName.

Solver – Nonlinear Static

Output Parameters
FileName

Full path and name for the initial conditions file.

CaseNum

Result case number within FileName to be used as the initial conditions.

Strand7 API Manual

Solver – Quasi-static
