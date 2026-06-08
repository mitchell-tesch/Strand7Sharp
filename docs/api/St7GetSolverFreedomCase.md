# St7GetSolverFreedomCase

Returns the freedom case assigned for the analysis. Multiple freedom cases may be specified for linear static
analysis using the St7EnableLSALoadCase function.

long St7GetSolverFreedomCase(long uID, long* CaseNum)

Input Parameters

uID

Strand7 model file ID.

Output Parameters

CaseNum

Freedom case number.
