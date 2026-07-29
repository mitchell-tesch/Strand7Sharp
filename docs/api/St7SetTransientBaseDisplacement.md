# St7SetTransientBaseDisplacement

Sets the initial base displacement for linear and nonlinear transient dynamic analysis. All restrained nodes in the
specified model will initially have this displacement.

long St7SetTransientBaseDisplacement(long uID, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
Doubles[0..2]
Base displacement components in the global XYZ system.

Usage
Transient base displacement is used as initial conditions for base acceleration and base velocity excitation.
