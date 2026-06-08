# St7GetGeometryCoedgeRadiation2

Returns the thermal radiation coefficient and ambient temperature assigned to the specified geometry coedge.
See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetGeometryCoedgeRadiation2(long uID, long CoedgeNum, long CaseNum,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

CoedgeNum

Coedge number.

CaseNum

Load case number.

Output Parameters
Doubles[0..1]

[0] – Radiation coefficient.

[1] – Ambient temperature.
