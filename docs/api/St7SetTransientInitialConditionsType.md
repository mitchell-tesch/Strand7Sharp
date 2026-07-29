# St7SetTransientInitialConditionsType

Sets the type of initial conditions to be used for linear and nonlinear transient dynamic analysis.

long St7SetTransientInitialConditionsType(long uID, long InitialType)
Input Parameters
uID
Strand7 model file ID.
InitialType
One of icNone, icAppliedVectors, icNodalVelocity or icFromFile.
