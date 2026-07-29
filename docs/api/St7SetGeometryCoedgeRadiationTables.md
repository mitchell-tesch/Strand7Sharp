# St7SetGeometryCoedgeRadiationTables

Sets the tables associated with the radiation coefficient assigned to the specified geometry coedge.

long St7SetGeometryCoedgeRadiationTables(long uID, long CoedgeNum, long CaseNum,
long* Tables)
Input Parameters
uID
Strand7 model file ID.
CoedgeNum
Coedge number.
CaseNum
Load case number.
Tables[0..2]
[0] – Temperature vs Time table ID associated with the radiation ambient temperature, or 0 for none.
[1] – Factor vs Temperature table ID associated with the radiation coefficient, or 0 for none.
[2] – Factor vs Time table ID associated with the radiation coefficient, or 0 for none.
