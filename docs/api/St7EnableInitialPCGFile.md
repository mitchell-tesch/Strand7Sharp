# St7EnableInitialPCGFile

Sets the PCG solver to use the specified result file as initial conditions. The result file name is specified using
St7SetInitialPCGFile.

Solver – General

long St7EnableInitialPCGFile(long uID, long SolverType)

Input Parameters

uID

Strand7 model file ID.

SolverType

Either stLinearStatic or stSteadyHeat.
