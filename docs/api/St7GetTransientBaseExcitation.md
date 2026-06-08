# St7GetTransientBaseExcitation

Returns the type of base excitation for linear and nonlinear transient dynamic analysis.

long St7GetTransientBaseExcitation(long uID, long* BaseType)

Input Parameters

uID

Strand7 model file ID.

Output Parameters
BaseType

One of beNone, beAcceleration, beVelocity or beDisplacement.
