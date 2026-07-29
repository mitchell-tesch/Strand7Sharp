# St7SetNodeAcceleration3

Sets the global acceleration components at the specified node. These acceleration values are not used as initial
conditions when performing transient analysis, rather, they are used to generate body forces when acting on
masses.

long St7SetNodeAcceleration3(long uID, long NodeNum, long CaseNum,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
NodeNum
Node number.
CaseNum
Load case number.
Doubles[0..2]
A 3-element array describing the acceleration components of the specified node in the global XYZ
system.
