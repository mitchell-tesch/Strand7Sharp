# St7GetTransientInitialConditionsNodalVelocity

Returns the load case that specifies the initial velocity for linear and nonlinear transient dynamic analysis. The
initial velocity components are defined by the Initial Velocity nodal attribute.

long St7GetTransientInitialConditionsNodalVelocity(long uID, long* CaseNum)

Input Parameters

uID

Strand7 model file ID.

Output Parameters

CaseNum

Load case number.
