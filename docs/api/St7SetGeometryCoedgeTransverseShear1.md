# St7SetGeometryCoedgeTransverseShear1

Assigns a transverse shear stress to the specified geometry coedge.

long St7SetGeometryCoedgeTransverseShear1(long uID, long CoedgeNum, long CaseNum,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
CoedgeNum
Coedge number.
CaseNum
Load case number.
Doubles[0]
Transverse shear stress.
