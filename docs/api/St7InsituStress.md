# St7InsituStress

Generates the soil in-situ stress distribution.

long St7InsituStress(long uID, long Mode, long Wait, long* Integers,
double* Doubles, long* ProcessID, long* WarningCode)
Input Parameters
uID
Strand7 model file ID.
Mode
One of smNormalRun, smNormalCloseRun, smProgressRun or smBackgroundRun. See Solver Options for
additional information.
Wait
Solver execution mode; either btTrue to halt execution of the caller until the solve is complete, or
btFalse to pass control back to the caller immediately after the function is called.
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
Output Parameters
ProcessID
ID number for the solver process. Applicable if Wait is btFalse.
WarningCode
One of wcInsituNoWarning, wcInsituUnconverged or wcInsituTensileStress.

Utility Functions
