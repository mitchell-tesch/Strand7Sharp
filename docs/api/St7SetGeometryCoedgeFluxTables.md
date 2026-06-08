# St7SetGeometryCoedgeFluxTables

Sets the tables associated with the heat flux attribute assigned to the specified geometry coedge.

long St7SetGeometryCoedgeFluxTables(long uID, long CoedgeNum, long CaseNum,

long* Tables)

Input Parameters

uID

Strand7 model file ID.

CoedgeNum

Coedge number.

CaseNum

Load case number.

Tables[0..1]

[0] – Factor vs Time table ID associated with the heat flux, or 0 for none.

[1] – Factor vs Temperature table ID associated with the heat flux, or 0 for none.
