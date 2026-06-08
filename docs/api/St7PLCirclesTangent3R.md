# St7PLCirclesTangent3R

Two circles are defined and the two lines that are tangent to both circles are found. Four new nodes
are generated, two on each of the circles (at the intersection between the tangent lines and the
circles). The two circles are defined by centres P1 and P2, and radii R1 and R2 respectively. P3 is used
to define the plane of the two circles.

long St7PLCirclesTangent3R(long uID, double* P1, double* P2, double* P3,

double R1, double R2)

Input Parameters

uID

Strand7 model file ID.

P1[0..2]

Point 1 in global XYZ coordinates.

P2[0..2]

Point 2 in global XYZ coordinates.

P3[0..2]

Point 3 in global XYZ coordinates.

R1

R2

Radius of circle centred at P1.

Radius of circle centred at P2.

Dependencies

Points and Lines Target

Target beam type and property assigned using St7SetPLTarget.

Default Group

Target group for the beams is specified by St7SetDefaultGroupID.
