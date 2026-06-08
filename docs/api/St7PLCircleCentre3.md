# St7PLCircleCentre3

Finds the centre of a circle. A new node is generated at this location. The circle is defined by three
points on the circumference.

long St7PLCircleCentre3(long uID, double* P1, double* P2, double* P3)

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

Default Group

Target group for the beams is specified by St7SetDefaultGroupID.
