# St7GetNLAPseudoTime

Returns the pseudo time in the specified increment for nonlinear static analysis.

Strand7 API Manual

long St7GetNLAPseudoTime(long uID, long Stage, long Increment, double* Time)

Input Parameters

uID

Strand7 model file ID.

Stage

Stage index – use 0 for unstaged analysis.

Increment

Increment number.

Output Parameters

Time

Pseudo time.
