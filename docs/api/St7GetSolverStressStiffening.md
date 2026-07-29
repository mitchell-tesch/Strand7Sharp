# St7GetSolverStressStiffening

Returns the state of the stress stiffening option for natural frequency and linear transient dynamic analyses with
initial conditions.

long St7GetSolverStressStiffening(long uID, bool* AddStressStiffening)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
AddStressStiffening
True if the stress stiffening effects are included.
