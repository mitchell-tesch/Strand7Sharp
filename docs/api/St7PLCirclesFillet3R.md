# St7PLCirclesFillet3R

Generates a line of beams or nodes on a circular fillet between two circles. The fillet touches each of
the two circles at a single tangent point. The two circles are defined by centres P1 and P2 and radii R1
and R2 respectively. A third point, P3, is used to define the plane of the circles. The radius of the fillet
is specified as R3.
Note that this tool will not produce any results if one of the circles is completely enclosed by the
other or if the circles are further than 2 x R3 apart.

long St7PLCirclesFillet3R(long uID, double* P1, double* P2, double* P3,
double R1, double R2, double R3, long NumSteps, bool FullCircle)
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
Radius of circle centred at P1.
R2
Radius of circle centred at P2.
R3
Fillet radius.
NumSteps
Number of steps.

FullCircle
True to span the full 360°.
False to span the angle between the circle and line tangents.
Dependencies
Points and Lines Target
Target beam type and property assigned using St7SetPLTarget.
Default Group
Target group for the beams is specified by St7SetDefaultGroupID.
