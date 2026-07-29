# St7DefinePlaneP3

Creates a new plane definition using three points in the global XYZ system.

long St7DefinePlaneP3(long uID, double* P1, double* P2, double* P3,
long* PlaneID)
Input Parameters
uID
Strand7 model file ID.
P1[0..2]
Point 1 in global XYZ coordinates.
P2[0..2]
Point 2 in global XYZ coordinates.
P3[0..2]
Point 3 in global XYZ coordinates.
Output Parameters
PlaneID
Plane identifier.
