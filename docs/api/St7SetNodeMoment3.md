# St7SetNodeMoment3

Sets the point moment acting on the specified node in the global XYZ system.

long St7SetNodeMoment3(long uID, long NodeNum, long CaseNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
NodeNum
Node number.
CaseNum
Load case number.
Doubles[0..2]
A 3-element array describing the nodal moment in the global XYZ system.
