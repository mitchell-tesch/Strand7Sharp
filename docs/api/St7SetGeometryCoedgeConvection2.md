# St7SetGeometryCoedgeConvection2

Assigns a thermal convection coefficient and ambient temperature to the specified geometry coedge.

long St7SetGeometryCoedgeConvection2(long uID, long CoedgeNum, long CaseNum,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Coedge Attributes – Set

CoedgeNum

Coedge number.

CaseNum

Load case number.

Doubles[0..1]

[0] – Convection coefficient.

[1] – Ambient temperature.
