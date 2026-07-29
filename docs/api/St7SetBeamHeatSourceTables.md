# St7SetBeamHeatSourceTables

Sets the tables associated with the heat source for the specified beam.

long St7SetBeamHeatSourceTables(long uID, long BeamNum, long CaseNum,
long* Tables)
Input Parameters
uID
Strand7 model file ID.
BeamNum
Beam number.
CaseNum
Load case number.
Tables[0..1]
[0] – Factor vs Time table ID associated with the heat source, or 0 for none.
[1] – Factor vs Temperature table ID associated with the heat source, or 0 for none.
