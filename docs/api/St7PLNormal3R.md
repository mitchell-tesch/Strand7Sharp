# St7PLNormal3R

Finds the centre of a circle with radius R such that a straight line between P1 and P2 is tangent to the
circle and touches the circle at P1. P3 is necessary to define the plane of the circle. The line between
P1 and the centre of the circle will be normal to the line between P1 and P2.

long St7PLNormal3R(long uID, double* P1, double* P2, double* P3, double Radius,

long NumSteps)

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

Radius.

NumSteps

Number of steps.

Dependencies

Points and Lines Target

Target beam type and property assigned using St7SetPLTarget.

Default Group

Target group for the beams is specified by St7SetDefaultGroupID.
