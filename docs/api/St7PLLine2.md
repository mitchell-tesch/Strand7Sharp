# St7PLLine2

Generates a line of nodes or beam elements on a straight line between the two end points, P1 and
P2.

long St7PLLine2(long uID, double* P1, double* P2, long NumSteps)

Input Parameters

uID

Strand7 model file ID.

P1[0..2]

Start of line in global XYZ coordinates.

P2[0..2]

End of line in global XYZ coordinates.

NumSteps

Number of steps.

Dependencies

Points and Lines Target

Target beam type and property assigned using St7SetPLTarget.

Default Group

Target group for the beams is specified by St7SetDefaultGroupID.
