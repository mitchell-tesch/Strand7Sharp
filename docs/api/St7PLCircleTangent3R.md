# St7PLCircleTangent3R

Locates the intersection between a circe and a tangent. The circle is defined by a single point, P1, and
a radius R1. The line is assumed to be tangent to the circle and to pass through P2. P3 is used to
define the plane of the circle.

long St7PLCircleTangent3R(long uID, double* P1, double* P2, double* P3,
double Radius)
Input Parameters
uID
Strand7 model file ID.
P1[0..2]
Point 1 in global XYZ coordinates.
P2[0..2]
Point 2 in global XYZ coordinates.
P3[0..2]
Point 3 in global XYZ coordinates.

Radius
Radius of circle centred at P1.
Dependencies
Points and Lines Target
Target beam type and property assigned using St7SetPLTarget.
Default Group
Target group for the beams is specified by St7SetDefaultGroupID.
