# St7GetPlateHeatSourceTables

Returns the tables associated with the heat source assigned to the specified plate. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetPlateHeatSourceTables(long uID, long PlateNum, long CaseNum,
long* Tables)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number.
CaseNum
Load case number.
Output Parameters
Tables[0..1]
[0] – Factor vs Time table ID associated with the heat source, or 0 for none.
[1] – Factor vs Temperature table ID associated with the heat source, or 0 for none.
