# St7SetNLAFreedomIncrementFactor

Assigns the freedom case factors for the specified increment in the nonlinear static analysis load table.

long St7SetNLAFreedomIncrementFactor(long uID, long Stage, long Increment,

long CaseNum, double Factor)

Input Parameters

uID

Strand7 model file ID.

Stage

Stage index – use 0 for unstaged analysis.

Increment

Increment number.

CaseNum

Freedom case number.

Factor

Freedom case factor.

Solver – Nonlinear Static
