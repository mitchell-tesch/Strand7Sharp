# St7PLExtend2R

Extends a line by the distance R and generates a node at the new end of the line. The line is defined
by two points, P1 and P2.

Strand7 API Manual

long St7PLExtend2R(long uID, double* P1, double* P2, double Radius,

long NumSteps)

Input Parameters

uID

Strand7 model file ID.

P1[0..2]

Point 1 in global XYZ coordinates.

P2[0..2]

Point 2 in global XYZ coordinates.

Radius

Radius.

NumSteps

Number of steps.

Dependencies

Points and Lines Target

Target beam type and property assigned using St7SetPLTarget.

Default Group

Target group for the beams is specified by St7SetDefaultGroupID.
