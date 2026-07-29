# St7SetTransientInitialConditionsVectors

Sets the initial acceleration and velocity vectors used for linear and nonlinear transient dynamic analysis. A
uniform acceleration and velocity is applied to all nodes.

long St7SetTransientInitialConditionsVectors(long uID, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
Doubles[0..5]
[0..2] – Initial acceleration components in the global XYZ system.
[3..5] – Initial velocity components in the global XYZ system.
