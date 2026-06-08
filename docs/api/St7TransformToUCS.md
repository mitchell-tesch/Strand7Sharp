# St7TransformToUCS

Transforms a position specified in the global XYZ system to a User Coordinate System (UCS).

long St7TransformToUCS(long uID, long UCSId, double* XYZ)

Input Parameters

uID

Strand7 model file ID.

UCSId

ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.

Input-Output Parameters

XYZ[0..2]

The position as a 3-element array. The global coordinates to be transformed are input in this array. The
function call then returns the transformed UCS coordinates in this array in 123 DoF order.
