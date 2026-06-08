# St7SetGeometryCoedgeRadiation2

Assigns a thermal radiation coefficient and ambient temperature to the specified geometry coedge.

long St7SetGeometryCoedgeRadiation2(long uID, long CoedgeNum, long CaseNum,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

CoedgeNum

Coedge number.

Strand7 API Manual

CaseNum

Load case number.

Doubles[0..1]

[0] – Radiation coefficient.

[1] – Ambient temperature.
