# St7PLEllipseO3

Generates a line of nodes and/or beam elements around an ellipse. The ellipse is centred at P1 and
passes through P2 and P3.

long St7PLEllipseO3(long uID, double* P1, double* P2, double* P3, long NumSteps,

bool FullCircle)

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

NumSteps

Number of steps.

FullCircle

True to span the full 360°.

False to span the angle between P2 and P3.

Dependencies

Points and Lines Target

Target beam type and property assigned using St7SetPLTarget.

Default Group

Target group for the beams is specified by St7SetDefaultGroupID.
