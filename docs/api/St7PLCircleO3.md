# St7PLCircleO3

Generates a line of nodes and/or beam elements around the circumference of a circle. P1 defines the
centre of the circle, P2 is a point on the circumference of the circle and P3 is used to define the plane
of the circle.

Tools – Create

long St7PLCircleO3(long uID, double* P1, double* P2, double* P3, long NumSteps,

bool FullCircle)

Input Parameters

uID

Strand7 model file ID.

P1[0..2]

Point 1 in global XYZ coordinates.

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
