# St7PLCirclesIntersect3R

Generates two new nodes at the points where two overlapping circles intersect. The centre of each
circle is defined using P1 and P2. The radius of each circle is defined by R1 and R2 respectively. P3 is
used to define the plane of the two circles. Note that in the special case where the points P1 and P2
are R1+R2 apart, only one point is generated.

Tools – Create

long St7PLCirclesIntersect3R(long uID, double* P1, double* P2, double* P3,

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
