# St7GetNodeHeatSource1

Returns the heat source assigned at the specified node. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetNodeHeatSource1(long uID, long NodeNum, long CaseNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

NodeNum

Node number.

CaseNum

Load case number.

Output Parameters
Doubles[0]

Heat source.

Strand7 API Manual
