# St7SetNodeInitialVelocity3

Sets the initial global velocity components for the specified node. These initial conditions are used when
performing transient dynamic analysis.

long St7SetNodeInitialVelocity3(long uID, long NodeNum, long CaseNum,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
NodeNum
Node number.
CaseNum
Load case number.
Doubles[0..2]
A 3-element array describing the initial velocity components for the specified node in the global XYZ
system.
