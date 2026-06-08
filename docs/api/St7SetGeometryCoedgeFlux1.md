# St7SetGeometryCoedgeFlux1

Assigns a heat flux to the specified geometry coedge.

long St7SetGeometryCoedgeFlux1(long uID, long CoedgeNum, long CaseNum,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

CoedgeNum

Coedge number.

CaseNum

Load case number.

Coedge Attributes – Set

Doubles[0]

The heat flux through the edge.
