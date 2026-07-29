# St7SetNodeTemperatureTable

Specifies the table to be associated with the temperature at the specified node. A table can only be assigned for
nodes with the appropriate table temperature type, as set using the St7SetNodeTemperatureType1 function.

long St7SetNodeTemperatureTable(long uID, long NodeNum, long CaseNum,
long TableID)
Input Parameters
uID
Strand7 model file ID.
NodeNum
Node number.
CaseNum
Load case number.

TableID
Temperature vs Time table ID associated with the node temperature, or 0 for none.
