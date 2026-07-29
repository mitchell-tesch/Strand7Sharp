# St7PLAverage2

Creates a point such that its coordinates are the average of P1 and P2 in the prescribed coordinate
system.

long St7PLAverage2(long uID, double* P1, double* P2, long UCSId)
Input Parameters
uID
Strand7 model file ID.
P1[0..2]
Point 1 in global XYZ coordinates.
P2[0..2]
Point 2 in global XYZ coordinates.
UCSId
Coordinate system ID.

Dependencies
Points and Lines Target
Target beam type and property assigned using St7SetPLTarget.
Default Group
Target group for the beams is specified by St7SetDefaultGroupID.
