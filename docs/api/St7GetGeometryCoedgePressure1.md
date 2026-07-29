# St7GetGeometryCoedgePressure1

Returns the normal edge pressure applied to the specified geometry coedge. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetGeometryCoedgePressure1(long uID, long CoedgeNum, long CaseNum,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
CoedgeNum
Coedge number.
CaseNum
Load case number.
Output Parameters
Doubles[0]
Edge pressure value.
