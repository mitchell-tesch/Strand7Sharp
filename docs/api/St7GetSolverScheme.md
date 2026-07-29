# St7GetSolverScheme

Returns the scheme assigned for the solution of the linear system arising from the finite element model.

long St7GetSolverScheme(long uID, long* Scheme)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
Scheme
One of stSkyline, stSparse or stIterativePCG.
