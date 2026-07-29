# St7SetBeamFluxTables

Sets the tables associated with the heat flux for the specified beam end.

long St7SetBeamFluxTables(long uID, long BeamNum, long BeamEnd, long CaseNum,
long* Tables)
Input Parameters
uID
Strand7 model file ID.
BeamNum
Beam number.
BeamEnd
Beam end; either 1 or 2.
CaseNum
Load case number.
Tables[0..1]
[0] – Factor vs Time table ID associated with the heat flux, or 0 for none.
[1] – Factor vs Temperature table ID associated with the heat flux, or 0 for none.
