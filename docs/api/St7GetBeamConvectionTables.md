# St7GetBeamConvectionTables

Returns the tables associated with convection coefficient for the specified beam end. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetBeamConvectionTables(long uID, long BeamNum, long BeamEnd,
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
Output Parameters
Tables[0..2]
[0] – Temperature vs Time table ID associated with the convection ambient temperature, or 0 for
none.

[1] – Factor vs Temperature table ID associated with the convection coefficient, or 0 for none.
[2] – Factor vs Time table ID associated with the convection coefficient, or 0 for none.
