# St7VectorTransformToUCS

Transforms a vector specified in the global XYZ system to an arbitrary User Coordinate System (UCS) frame, at a
given position in space.

Utility Functions

long St7VectorTransformToUCS(long uID, long UCSId, double* Position,

double* VXYZ)

Input Parameters

uID

Strand7 model file ID.

UCSId

ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.

Position[0..2]

The position of the transformation in global coordinates as a 3-element array. The UCS directions into
which VXYZ will be transformed are evaluated at this point.

Input-Output Parameters

VXYZ[0..2]

The vector defined as a 3-element array. The vector to be transformed is input in this array, defined in
the global XYZ system. The function call then returns the transformed vector in this array in 123 DoF
order, defined in the UCS frame.
