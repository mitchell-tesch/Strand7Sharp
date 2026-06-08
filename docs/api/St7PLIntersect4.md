# St7PLIntersect4

Generates a new node at the intersection of two lines. Each of the two lines is defined by two points,
P1-P2 for line 1 and P3-P4 for line 2. All four nodes must lie on the same plane. If this is not the case
then the message "Intersection not found" will be displayed.

Tools – Create

long St7PLIntersect4(long uID, double* P1, double* P2, double* P3, double* P4)

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

Dependencies

Points and Lines Target

Target beam type and property assigned using St7SetPLTarget.

Default Group

Target group for the beams is specified by St7SetDefaultGroupID.
