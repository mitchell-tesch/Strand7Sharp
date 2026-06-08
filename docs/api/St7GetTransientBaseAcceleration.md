# St7GetTransientBaseAcceleration

Returns the initial base acceleration assigned for linear and nonlinear transient dynamic analysis. All restrained
nodes in the specified model will initially have this acceleration.

long St7GetTransientBaseAcceleration(long uID, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Output Parameters
Doubles[0..2]

Base acceleration components in the global XYZ system.

Usage

Transient base acceleration is used as initial conditions for base velocity and base displacement excitation.

Solver – Linear and Nonlinear Transient Dynamic
