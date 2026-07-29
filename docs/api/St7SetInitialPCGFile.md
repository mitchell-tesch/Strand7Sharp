# St7SetInitialPCGFile

Assigns the initial conditions file used by the PCG solver.

long St7SetInitialPCGFile(long uID, long SolverType, char* FileName)
Input Parameters
uID
Strand7 model file ID.
SolverType
Either stLinearStatic or stSteadyHeat.
FileName
Full path and name for the initial conditions file for the PCG solver.
