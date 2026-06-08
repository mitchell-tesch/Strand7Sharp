# St7VectorTransformToXYZ

Transforms a vector specified in a User Coordinate System (UCS) frame to the global XYZ system, at a given
position in space.

long St7VectorTransformToXYZ(long uID, long UCSId, double* Position,

double* VXYZ)

Input Parameters

uID

Strand7 model file ID.

UCSId

ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.

Position[0..2]

The position in global XYZ coordinates as a 3-element array. The UCS directions into which VXYZ will be
transformed are evaluated at this point.

Input-Output Parameters

VXYZ[0..2]

The vector defined as a 3-element array. The vector to be transformed is input in this array, defined in
the UCS frame. The function call then returns the transformed vector in this array in 123 DoF order,
defined in the global XYZ system.

Strand7 API Manual
