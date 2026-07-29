# St7GetGeometryCoedgeFluxTables

Returns the tables associated with the heat flux assigned to the specified geometry coedge. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetGeometryCoedgeFluxTables(long uID, long CoedgeNum, long CaseNum,
long* Tables)
Input Parameters
uID
Strand7 model file ID.
CoedgeNum
Coedge number.
CaseNum
Load case number.
Output Parameters
Tables[0..1]
[0] – Factor vs Time table ID associated with the heat flux, or 0 for none.
[1] – Factor vs Temperature table ID associated with the heat flux, or 0 for none.
