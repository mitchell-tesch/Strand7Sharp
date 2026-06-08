# St7PLFillet4R

Generates a line of nodes or beam elements along a circular arc. The arc is located such that the two
intersecting straight lines are tangents to the arc. The arc forms a fillet between the lines. The lines
are defined using four points. Points P1 and P2 define the first line and points P3 and P4 define the
second line. The four points must be co-planar.

long St7PLFillet4R(long uID, double* P1, double* P2, double* P3, double* P4,

double Radius, long NumSteps)

Input Parameters

uID

Strand7 model file ID.

P1[0..2]

Point 1 in global XYZ coordinates.

P2[0..2]

Point 2 in global XYZ coordinates.

P3[0..2]

Point 3 in global XYZ coordinates.

P4[0..2]

Point 4 in global XYZ coordinates.

Radius

Fillet radius.

NumSteps

Number of steps.

Dependencies

Points and Lines Target

Target beam type and property assigned using St7SetPLTarget.

Default Group

Target group for the beams is specified by St7SetDefaultGroupID.
