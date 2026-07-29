# St7SetPlateHeatSourceTables

Sets the tables associated with the heat source for the specified plate.

long St7SetPlateHeatSourceTables(long uID, long PlateNum, long CaseNum,
long* Tables)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number.
CaseNum
Load case number.
Tables[0..1]
[0] – Factor vs Time table ID associated with the heat source, or 0 for none.
[1] – Factor vs Temperature table ID associated with the heat source, or 0 for none.
