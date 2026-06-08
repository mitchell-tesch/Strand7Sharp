# St7PLCircleLineIntersect3

Generates two nodes at the intersection between a circle and a straight line (except in the case
where the line is a tangent to the circle in which case only one point is generated). The circle is
defined by a point at the centre, P1, and a radius R. The line is defined by two points, P2 and P3. If
one of these points lies inside the circle, the line is extended to find the second point of intersection.

long St7PLCircleLineIntersect3(long uID, double* P1, double* P2, double* P3,

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

Strand7 API Manual

Radius

Radius of circle.

Dependencies

Points and Lines Target

Target beam type and property assigned using St7SetPLTarget.

Default Group

Target group for the beams is specified by St7SetDefaultGroupID.
