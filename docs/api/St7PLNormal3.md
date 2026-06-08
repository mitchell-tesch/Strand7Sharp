# St7PLNormal3

Generates two perpendicular lines. A straight line is created between P2-P3. The second line is
created from P1 to a new node on P2-P3 such that the second line is perpendicular to P2-P3.

long St7PLNormal3(long uID, double* P1, double* P2, double* P3)

Input Parameters

uID

Strand7 model file ID.

P1[0..2]

Point 1 in global XYZ coordinates.

P2[0..2]

Point 2 in global XYZ coordinates.

P3[0..2]

Point 3 in global XYZ coordinates.

Dependencies

Points and Lines Target

Target beam type and property assigned using St7SetPLTarget.

Tools – Create

Default Group

Target group for the beams is specified by St7SetDefaultGroupID.
