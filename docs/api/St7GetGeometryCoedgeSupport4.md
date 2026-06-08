# St7GetGeometryCoedgeSupport4

Returns the elastic edge support assigned to the specified geometry coedge. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetGeometryCoedgeSupport4(long uID, long CoedgeNum, long CaseNum,

long* Status, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

CoedgeNum

Coedge number.

CaseNum

Freedom case number.

Output Parameters
Status[0..1]

[0] –  Compression-only support; either btTrue or btFalse.

[1] –  Limited bearing capacity; either btTrue or btFalse.

Doubles[0..3]

[0] – Elastic support value in the normal direction.

[1] – Elastic support value in the lateral direction.

Strand7 API Manual

[2] – Support gap.  Only relevant if Status[0] is set to btTrue.

[3] – Bearing capacity.  Only relevant if Status[1] is set to btTrue.
