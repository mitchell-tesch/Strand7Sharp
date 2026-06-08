# St7PLCircleLineInnerFillet3R

Generates a circular arc fillet between a straight line and a circle. The circle is defined by P1, at the
centre and a radius R1. The line is defined by P2 and P3. The radius of the fillet is specified as R2.

long St7PLCircleLineInnerFillet3R(long uID, double* P1, double* P2, double* P3,

double R1, double R2, long NumSteps, bool FullCircle)

Input Parameters

uID

Strand7 model file ID.

P1[0..2]

Point 1 in global XYZ coordinates.

Strand7 API Manual

P2[0..2]

Point 2 in global XYZ coordinates.

P3[0..2]

Point 3 in global XYZ coordinates.

R1

R2

Radius of circle centred at P1.

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
