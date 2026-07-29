# St7SetGeometryCoedgePressure1

Assigns a normal pressure to the specified geometry coedge.

long St7SetGeometryCoedgePressure1(long uID, long CoedgeNum, long CaseNum,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
CoedgeNum
Coedge number.
CaseNum
Load case number.
Doubles[0]
Edge pressure value.
