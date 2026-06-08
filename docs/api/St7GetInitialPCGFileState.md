# St7GetInitialPCGFileState

Returns the enabled state assigned for the PCG initial conditions.

long St7GetInitialPCGFileState(long uID, long SolverType, bool* Enabled)

Input Parameters

uID

Strand7 model file ID.

SolverType

Either stLinearStatic or stSteadyHeat.

Output Parameters

Enabled

True if the starting vector for the PCG solver is obtained from the initial conditions file.
