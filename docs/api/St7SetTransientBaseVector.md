# St7SetTransientBaseVector

Sets the base excitation vector for linear and nonlinear transient dynamic analysis. The values in the base
excitation tables (acceleration, velocity and displacement), are multiplied by the respective base vector
component.

long St7SetTransientBaseVector(long uID, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Doubles[0..2]

Components in the global XYZ system.
