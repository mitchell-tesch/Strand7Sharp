# St7GetSolverLoadCaseCableInertia

Returns the load case that specifies the inertia loads applied to cable elements in the linear solvers.  The weight of
the cable defines the cable stiffness.

long St7GetSolverLoadCaseCableInertia(long uID, long* CaseNum)

Input Parameters

uID

Strand7 model file ID.

Output Parameters

CaseNum

Load case number.
