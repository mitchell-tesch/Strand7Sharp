# St7PLCurve3

Generates a line of beam elements or nodes around a variable radius curve. The curve is centred at
P1. The radius spirals from P2 to P3. It is similar to an ellipse.

long St7PLCurve3(long uID, double* P1, double* P2, double* P3, long NumSteps)
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

Dependencies
Points and Lines Target
Target beam type and property assigned using St7SetPLTarget.
Default Group
Target group for the beams is specified by St7SetDefaultGroupID.
