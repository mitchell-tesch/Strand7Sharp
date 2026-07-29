# St7SetGeometryCoedgePressure3

Assigns a global pressure to the specified geometry coedge.

long St7SetGeometryCoedgePressure3(long uID, long CoedgeNum, long CaseNum,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
CoedgeNum
Coedge number.
CaseNum
Load case number.
Doubles[0..2]
A 3-element array containing the pressure components in the global XYZ system.
