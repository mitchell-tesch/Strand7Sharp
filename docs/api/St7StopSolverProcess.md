# St7StopSolverProcess

Stops the execution of the specified solver process.

long St7StopSolverProcess(long ProcessID)
Input Parameters
ProcessID
Solver process ID.
Usage
The function terminates the solver using a brute force approach (equivalent to terminating the process using
Task Manager). It is applicable only to the .exe solver when this is executed via St7RunSolverProcess with Wait
set to btFalse. A solver process terminated using this function may leave behind its temporary files in the
ScratchPath folder (see St7OpenFile); these will need to be deleted manually.
