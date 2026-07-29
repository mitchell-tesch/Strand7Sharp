# St7GetInsituStressOptions

Returns the options used in the last execution of St7InsituStress.

long St7GetInsituStressOptions(long uID, long* Integers, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
Integers[0..8]
[ipInsituGravityCase] – Load case in which gravity is defined.
[ipInsituFreedomCase] – Freedom case.
[ipInsituStageIndex] – Stage at which to calculate the in-situ stress, or 0 to have all groups active.
[ipInsituUseExisting] – btTrue to use the existing in-situ stress distribution as the initial
conditions.
[ipInsituReplaceK0] – Calculate horizontal stress ratio (K0) from stress results.
[ipInsituMaxIterations] – Iteration limit used by the solver.
[ipInsituAllowIterations] – btTrue to allow the solver to add iterations.
[ipInsituSolverScheme] – one of stSkyline, stSparse or stIterativePCG.
[ipInsituMatrixSort] – one of rnNone, rnTree, rnGeometry or rnAMD.
Doubles[0..1]
[ipInsituDefaultFluidLevel] – Default fluid level.
[ipInsituDefaultFluidDensity] – Default fluid mass density per unit volume.

Cleaning
