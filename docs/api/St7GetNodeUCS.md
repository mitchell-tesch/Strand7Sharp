# St7GetNodeUCS

Returns the coordinates of the specified node in a given UCS in its undeformed position.

long St7GetNodeUCS(long uID, long NodeNum, long UCSId, double* XYZ)

Input Parameters

uID

Strand7 model file ID.

NodeNum

Node number.

UCSId

ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.

Output Parameters
XYZ[0..2]

Node position as a 3-element array specifying the position according to the 123 axis UCS convention.
