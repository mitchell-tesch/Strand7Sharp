# St7GetInitialPCGFile

Returns the initial conditions file assigned to the PCG solver.

long St7GetInitialPCGFile(long uID, long SolverType, char* FileName,

long MaxStringLen)

Input Parameters

uID

Strand7 model file ID.

SolverType

Either stLinearStatic or stSteadyHeat.

MaxStringLen

Maximum number of characters allocated for FileName.

Output Parameters
FileName

Full path and name for the initial conditions file for the PCG solver.
