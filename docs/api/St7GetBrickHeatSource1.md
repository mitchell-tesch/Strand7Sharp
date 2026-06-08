# St7GetBrickHeatSource1

Returns the heat source assigned to the specified brick. This attribute is only used when performing heat transfer
analysis. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetBrickHeatSource1(long uID, long BrickNum, long CaseNum,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BrickNum

Brick number.

Brick Attributes – Get

CaseNum

Load case number.

Output Parameters
Doubles[0]

Heat source.
