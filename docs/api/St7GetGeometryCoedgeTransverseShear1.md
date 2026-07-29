# St7GetGeometryCoedgeTransverseShear1

Returns the transverse shear stress assigned to the specified geometry coedge. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetGeometryCoedgeTransverseShear1(long uID, long CoedgeNum, long CaseNum,
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
Transverse shear stress.
