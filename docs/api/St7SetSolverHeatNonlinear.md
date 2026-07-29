# St7SetSolverHeatNonlinear

Sets the state of the nonlinear option for steady heat and transient heat analysis. Models containing radiative
boundary conditions or temperature dependent material conditions should use the nonlinear analysis option.

long St7SetSolverHeatNonlinear(long uID, bool Nonlinear)
Input Parameters
uID
Strand7 model file ID.
Nonlinear
True to perform nonlinear heat analyses. The nonlinear flag must be active to solve problems
incorporating radiative boundary conditions or temperature dependent material properties.

Solver – Natural Frequency and Transient Dynamic
