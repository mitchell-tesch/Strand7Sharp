# St7SetNodeKDamping3F

Sets the translational damping coefficients at the specified node.

long St7SetNodeKDamping3F(long uID, long NodeNum, long CaseNum, long UCSId,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
NodeNum
Node number.
CaseNum
Load case number.
UCSId
ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.
Doubles[0..2]
A 3-element array describing the damping factors for the specified node. Doubles[i-1] describes the
damping factor for the ith translational DoF according to the 123 axis definition in the specified UCS.
