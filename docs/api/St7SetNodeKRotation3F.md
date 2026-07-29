# St7SetNodeKRotation3F

Sets the rotational stiffness acting at the specified node.

long St7SetNodeKRotation3F(long uID, long NodeNum, long CaseNum, long UCSId,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
NodeNum
Node number.
CaseNum
Freedom case number.
UCSId
ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.

Doubles[0..2]
A 3-element array describing the rotational stiffnesses for the specified node. Doubles[i-1] describes
the stiffness for the ith rotational DoF according to the 456 axis definition in the specified UCS.
