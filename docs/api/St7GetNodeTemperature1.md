# St7GetNodeTemperature1

Returns the temperature value applied at the specified node. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetNodeTemperature1(long uID, long NodeNum, long CaseNum,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

NodeNum

Node number.

CaseNum

Load case number.

Output Parameters
Doubles[0]

The nodal temperature value at the specified node.
