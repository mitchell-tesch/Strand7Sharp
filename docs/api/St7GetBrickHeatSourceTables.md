# St7GetBrickHeatSourceTables

Returns the tables associated with the heat source assigned to the specified brick. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetBrickHeatSourceTables(long uID, long BrickNum, long CaseNum,
long* Tables)
Input Parameters
uID
Strand7 model file ID.
BrickNum
Brick number.
CaseNum
Load case number.
Output Parameters
Tables[0..1]
[0] – Factor vs Time table ID associated with the heat source, or 0 for none.
[1] – Factor vs Temperature table ID associated with the heat source, or 0 for none.
