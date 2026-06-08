# St7GetTransientInitialConditionsType

Returns the type of initial conditions assigned for linear and nonlinear transient dynamic analysis.

Strand7 API Manual

long St7GetTransientInitialConditionsType(long uID, long* InitialType)

Input Parameters

uID

Strand7 model file ID.

Output Parameters
InitialType

One of icNone, icAppliedVectors, icNodalVelocity or icFromFile.
