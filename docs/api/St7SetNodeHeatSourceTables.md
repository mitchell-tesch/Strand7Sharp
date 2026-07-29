# St7SetNodeHeatSourceTables

Sets the tables associated with the specified node heat source.

long St7SetNodeHeatSourceTables(long uID, long NodeNum, long CaseNum,
long* Tables)
Input Parameters
uID
Strand7 model file ID.
NodeNum
Node number.
CaseNum
Load case number.
Tables[0..1]
[0] – Factor vs Time table ID associated with the heat source, or 0 for none.
[1] – Factor vs Temperature table ID associated with the heat source, or 0 for none.
