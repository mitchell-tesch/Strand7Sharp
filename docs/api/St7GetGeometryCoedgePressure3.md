# St7GetGeometryCoedgePressure3

Returns the global edge pressure applied to the specified geometry coedge. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetGeometryCoedgePressure3(long uID, long CoedgeNum, long CaseNum,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
CoedgeNum
Coedge number.
CaseNum
Load case number.
Output Parameters
Doubles[0..2]
A 3-element array containing the pressure components in the global XYZ system.
