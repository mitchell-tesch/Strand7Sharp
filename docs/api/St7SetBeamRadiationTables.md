# St7SetBeamRadiationTables

Set the tables associated with the radiation coefficient for the specified beam end.

long St7SetBeamRadiationTables(long uID, long BeamNum, long BeamEnd,
long CaseNum, long* Tables)
Input Parameters
uID
Strand7 model file ID.
BeamNum
Beam number.
BeamEnd
Beam end; either 1 or 2.
CaseNum
Load case number.
Tables[0..2]
[0] – Temperature vs Time table ID associated with the radiation ambient temperature, or 0 for none.
[1] – Factor vs Temperature table ID associated with the radiation coefficient, or 0 for none.
[2] – Factor vs Time table ID associated with the radiation coefficient, or 0 for none.
