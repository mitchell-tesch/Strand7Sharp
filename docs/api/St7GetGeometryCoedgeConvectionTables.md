# St7GetGeometryCoedgeConvectionTables

Returns the tables associated with the convection coefficient assigned to the specified geometry coedge. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetGeometryCoedgeConvectionTables(long uID, long CoedgeNum, long CaseNum,

long* Tables)

Input Parameters

uID

Strand7 model file ID.

CoedgeNum

Coedge number.

CaseNum

Load case number.

Output Parameters
Tables[0..2]

[0] – Temperature vs Time table ID associated with the convection ambient temperature, or 0 for
none.

[1] – Factor vs Temperature table ID associated with the convection coefficient, or 0 for none.

[2] – Factor vs Time table ID associated with the convection coefficient, or 0 for none.

Coedge Attributes – Get
