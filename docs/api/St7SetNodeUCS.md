# St7SetNodeUCS

Sets the position of the specified node in a given UCS. A new node is created if the node number does not already
exist. If the new node number is not consecutive with the existing node total a series of nodes are created at the
origin such that the node list remains contiguous.

Strand7 API Manual

long St7SetNodeUCS(long uID, long NodeNum, long UCSId, double* XYZ)

Input Parameters

uID

Strand7 model file ID.

NodeNum

Node number.

UCSId

ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.

XYZ[0..2]

Node position as a 3-element array specifying the position according to the 123 axis UCS convention.
