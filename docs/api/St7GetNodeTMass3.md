# St7GetNodeTMass3

Returns the translational mass components assigned to the specified node. Translational masses are active in all
load and freedom cases.

long St7GetNodeTMass3(long uID, long NodeNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
NodeNum
Node number.
Output Parameters
Doubles[0..2]
A 3-element array describing the translational mass for the specified node in the global XYZ system.
