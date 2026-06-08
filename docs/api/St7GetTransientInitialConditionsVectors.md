# St7GetTransientInitialConditionsVectors

Returns the initial acceleration and velocity vectors assigned for linear and nonlinear transient dynamic analysis. A
uniform acceleration and velocity is applied to all nodes.

long St7GetTransientInitialConditionsVectors(long uID, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Output Parameters
Doubles[0..5]

[0..2] – Initial acceleration components in the global XYZ system.

[3..5] – Initial velocity components in the global XYZ system.
