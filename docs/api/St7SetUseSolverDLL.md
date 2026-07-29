# St7SetUseSolverDLL

Sets the type of solver to be launched for future solver invocations; either the .exe solver or the .dll solver.

long St7SetUseSolverDLL(bool UseDLL)
Input Parameters
UseDLL
True to use the .dll solver.
False to use the .exe solver.
Usage
The default option of the .exe solver is safer since the solver is isolated from the user’s program. In this
configuration, launching the solver spawns a new process that runs independently of the process running the
user’s API program. When run using the .dll solver, the solve is run in the memory space of the user’s
application.
The advantages of the .dll solver are that the solver can be invoked with less overhead (i.e. it loads faster,
which could significantly reduce the total run time for applications requiring a very large number of solver
executions), and that more information about a solve’s termination can be accessed by the Strand7 API (see
Solver termination error codes).
The disadvantage of the .dll solver is that any abnormal termination of the solver will propogate to the user’s
application rather than being contained within the solver; this may terminate the user’s application.
