# St7GetBeamHeatSourceTables

Returns the tables associated with the heat source for the specified beam. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetBeamHeatSourceTables(long uID, long BeamNum, long CaseNum,

long* Tables)

Input Parameters

uID

Strand7 model file ID.

Beam Attributes – Get

BeamNum

Beam number.

CaseNum

Load case number.

Output Parameters
Tables[0..1]

[0] – Factor vs Time table ID associated with the heat source, or 0 for none.

[1] – Factor vs Temperature table ID associated with the heat source, or 0 for none.
