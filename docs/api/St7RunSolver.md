# St7RunSolver

Launches the specified Strand7 solver. All Strand7 solvers run as a separate process to the calling application.

long St7RunSolver(long uID, long Solver, long Mode, long Wait)
Input Parameters
uID
Strand7 model file ID.
Solver
One of the solver types listed in Solver Types.
Mode
One of smNormalRun, smNormalCloseRun, smProgressRun or smBackgroundRun. See Solver Options for
additional information.
Wait
Solver execution mode; either btTrue to halt execution of the caller until the solve is complete, or
btFalse to pass control back to the caller immediately after the function is called.
