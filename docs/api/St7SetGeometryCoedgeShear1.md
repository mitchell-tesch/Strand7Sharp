# St7SetGeometryCoedgeShear1

Assigns a shear stress along the specified geometry coedge.

Strand7 API Manual

long St7SetGeometryCoedgeShear1(long uID, long CoedgeNum, long CaseNum,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

CoedgeNum

Coedge number.

CaseNum

Load case number.

Doubles[0]

Shear stress.
