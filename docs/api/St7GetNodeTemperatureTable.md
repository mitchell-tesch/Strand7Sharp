# St7GetNodeTemperatureTable

Returns the table associated with the temperature at the specified node. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetNodeTemperatureTable(long uID, long NodeNum, long CaseNum,

long* TableID)

Input Parameters

uID

Strand7 model file ID.

NodeNum

Node number.

CaseNum

Load case number.

Output Parameters

TableID

Temperature vs Time table ID associated with the node temperature, or 0 for none.
