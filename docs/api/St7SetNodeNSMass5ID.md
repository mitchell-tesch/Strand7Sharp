# St7SetNodeNSMass5ID

Sets the non-structural mass at the specified node.

long St7SetNodeNSMass5ID(long uID, long NodeNum, long CaseNum, long ID,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
NodeNum
Node number.
CaseNum
Load case number.
ID
The non-structural mass ID.
Doubles[0..4]
[0] – The non-structural mass at the specified node.
[1] – The dynamic factor at the specified node. This factor is used to scale the non-structural mass
when performing dynamic analysis.
[2..4] – A 3-element array describing the offset in the global XYZ system.
