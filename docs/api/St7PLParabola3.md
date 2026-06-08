# St7PLParabola3

Generates a line of nodes or beam elements on a parabola passing through three points, P1, P2 and
P3.

long St7PLParabola3(long uID, double* P1, double* P2, double* P3, long NumSteps)

Input Parameters

uID

Strand7 model file ID.

Strand7 API Manual

P1[0..2]

Point 1 in global XYZ coordinates.

P2[0..2]

Point 2 in global XYZ coordinates.

P3[0..2]

Point 3 in global XYZ coordinates.

NumSteps

Number of steps.

Dependencies

Points and Lines Target

Target beam type and property assigned using St7SetPLTarget.

Default Group

Target group for the beams is specified by St7SetDefaultGroupID.
