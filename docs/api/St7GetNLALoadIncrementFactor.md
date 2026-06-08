# St7GetNLALoadIncrementFactor

Returns the load case factors assigned for the specified increment in the nonlinear static analysis load table.

long St7GetNLALoadIncrementFactor(long uID, long Stage, long Increment,

long CaseNum, double* Factor)

Input Parameters

uID

Strand7 model file ID.

Stage

Stage index – use 0 for unstaged analysis.

Increment

Increment number.

CaseNum

Load case number.

Output Parameters

Factor

Load case factor.
