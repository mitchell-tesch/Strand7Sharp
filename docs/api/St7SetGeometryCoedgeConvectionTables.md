# St7SetGeometryCoedgeConvectionTables

Sets the tables associated with the convection coefficient assigned to the specified geometry coedge.

long St7SetGeometryCoedgeConvectionTables(long uID, long CoedgeNum, long CaseNum,

long* Tables)

Input Parameters

uID

Strand7 model file ID.

CoedgeNum

Coedge number.

CaseNum

Load case number.

Tables[0..2]

[0] – Temperature vs Time table ID associated with the convection ambient temperature, or 0 for
none.

[1] – Factor vs Temperature table ID associated with the convection coefficient, or 0 for none.

[2] – Factor vs Time table ID associated with the convection coefficient, or 0 for none.
