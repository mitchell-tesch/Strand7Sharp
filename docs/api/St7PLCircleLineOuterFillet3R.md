# St7PLCircleLineOuterFillet3R

Generates a circular arc fillet (or full circle) between a straight line and a circle. The radius of the arc
can be set. The main circle is defined by point P1 and radius R1. The straight line is defined by points
P2-P3. The arc has fillet radius R2. Note that R1 must be greater than R2.

long St7PLCircleLineOuterFillet3R(long uID, double* P1, double* P2, double* P3,
double R1, double R2, long NumSteps, bool FullCircle)
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
