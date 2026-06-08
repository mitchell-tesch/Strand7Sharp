# St7GetTransientBaseTables

Returns the time tables associated with the base excitation components for linear and nonlinear transient
dynamic analysis.

Solver – Linear and Nonlinear Transient Dynamic

long St7GetTransientBaseTables(long uID, long BaseType, long* Integers)

Input Parameters

uID

Strand7 model file ID.

BaseType

One of beAcceleration, beVelocity or beDisplacement.

Output Parameters

Integers[0..2]

ID numbers for tables in the global XYZ directions, or 0 for none; Acceleration vs Time table for
beAcceleration, Velocity vs Time table for beVelocity, and Displacement vs Time table for
beDisplacement.
