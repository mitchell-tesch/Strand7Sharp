# St7GetTransientBaseVelocity

Returns the initial base velocity assigned for linear and nonlinear transient dynamic analysis. All restrained nodes
in the specified model will initially have this velocity.

long St7GetTransientBaseVelocity(long uID, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
Doubles[0..2]
Base velocity components in the global XYZ system.
Usage
Transient base velocity is used as initial conditions for base acceleration and base displacement excitation.
