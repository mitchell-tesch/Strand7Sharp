# St7GetBeamHeatSource1

Returns the heat source assigned to the specified beam. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetBeamHeatSource1(long uID, long BeamNum, long CaseNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BeamNum

Beam number.

CaseNum

Load case number.

Output Parameters
Doubles[0]

Heat source.
