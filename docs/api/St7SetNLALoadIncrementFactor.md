# St7SetNLALoadIncrementFactor

Assigns the load case factors for the specified increment in the nonlinear static analysis load table.

long St7SetNLALoadIncrementFactor(long uID, long Stage, long Increment,
long CaseNum, double Factor)
Input Parameters
uID
Strand7 model file ID.
Stage
Stage index – use 0 for unstaged analysis.
Increment
Increment number.
CaseNum
Load case number.
Factor
Load case factor.
