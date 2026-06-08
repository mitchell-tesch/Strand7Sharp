# St7GetGeometryCoedgeFlux1

Returns the heat flux assigned to the specified geometry coedge. See also St7GetEntityAttributeSequenceCount
and St7GetEntityAttributeSequence.

long St7GetGeometryCoedgeFlux1(long uID, long CoedgeNum, long CaseNum,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

CoedgeNum

Coedge number.

CaseNum

Load case number.

Output Parameters
Doubles[0]

The heat flux through the edge.
