# St7GetNodeXYZ

Returns the coordinates of the specified node in the global XYZ system in its undeformed position.

long St7GetNodeXYZ(long uID, long NodeNum, double* XYZ)
Input Parameters
uID
Strand7 model file ID.
NodeNum
Node number.
Output Parameters
XYZ[0..2]
Node position as a 3-element array in global XYZ coordinates.
