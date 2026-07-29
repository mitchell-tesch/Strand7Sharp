# St7SetNodeXYZ

Sets the position of the specified node in the global XYZ system. A new node is created if the node number does
not already exist. If the new node number is not consecutive with the existing node total a series of nodes are
created at the origin such that the node list remains contiguous.

long St7SetNodeXYZ(long uID, long NodeNum, double* XYZ)
Input Parameters
uID
Strand7 model file ID.
NodeNum
Node number.
XYZ[0..2]
Node position as a 3-element array in global XYZ coordinates.
