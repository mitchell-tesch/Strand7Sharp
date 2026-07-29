# St7GetNLAFreedomIncrementFactor

Returns the freedom case factors assigned for the specified increment in the nonlinear static analysis load table.

long St7GetNLAFreedomIncrementFactor(long uID, long Stage, long Increment,
long CaseNum, double* Factor)
Input Parameters
uID
Strand7 model file ID.
Stage
Stage index – use 0 for unstaged analysis.
Increment
Increment number.
CaseNum
Freedom case number.
Output Parameters
Factor
Freedom case factor.
