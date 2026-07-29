# St7SetNodeRMass3

Sets the rotational mass assigned to the specified node as three components. Rotational masses are active in all
load and freedom cases.

long St7SetNodeRMass3(long uID, long NodeNum, long UCSId, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
NodeNum
Node number.
UCSId
ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.
Doubles[0..2]
A 3-element array defining the rotational mass for the node about the axes of the specified UCS.
