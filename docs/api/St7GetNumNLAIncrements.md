# St7GetNumNLAIncrements

Returns the total number of increments assigned in the nonlinear static analysis load table.

long St7GetNumNLAIncrements(long uID, long Stage, long* NumIncrements)
Input Parameters
uID
Strand7 model file ID.
Stage
Stage index – use 0 for unstaged analysis.
Output Parameters
NumIncrements
Total number of increments.
