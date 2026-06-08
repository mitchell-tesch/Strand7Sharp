# St7InsertNLAIncrement

Inserts a new blank increment at the specified position in the nonlinear static analysis load table.

Strand7 API Manual

long St7InsertNLAIncrement(long uID, long Stage, long Increment, char* IncName)

Input Parameters

uID

Strand7 model file ID.

Stage

Stage index – use 0 for unstaged analysis.

Increment

Increment number.

IncName

String containing the increment name.
