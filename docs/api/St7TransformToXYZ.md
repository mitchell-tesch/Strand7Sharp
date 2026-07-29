# St7TransformToXYZ

Transforms a position specified in an arbitrary User Coordinate System (UCS) to the global XYZ system.

long St7TransformToXYZ(long uID, long UCSId, double* XYZ)
Input Parameters
uID
Strand7 model file ID.
UCSId
ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.
Input-Output Parameters
XYZ[0..2]
The position as a 3-element array. The UCS coordinates to be transformed are input in this array. The
function call then returns the transformed global coordinates in this array in 123 DoF order.
