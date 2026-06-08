# St7GetNLAIncrementName

Returns the name of the specified increment in the nonlinear static analysis load table.

long St7GetNLAIncrementName(long uID, long Stage, long Increment, char* IncName,

long MaxStringLen)

Input Parameters

uID

Strand7 model file ID.

Stage

Stage index – use 0 for unstaged analysis.

Increment

Increment number.

Solver – Nonlinear Static

MaxStringLen

Maximum number of characters allocated for IncName.

Output Parameters

IncName

String containing the increment name.
