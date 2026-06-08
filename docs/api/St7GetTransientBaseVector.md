# St7GetTransientBaseVector

Returns the base excitation vector assigned for linear and nonlinear transient dynamic analysis. The values in the
base excitation tables (acceleration, velocity and displacement), are multiplied by the respective base vector
component.

Strand7 API Manual

long St7GetTransientBaseVector(long uID, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Output Parameters
Doubles[0..2]

Components in the global XYZ system.
