# St7GetPlateEdgeSupport4

Returns the elastic support applied at the specified plate edge. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetPlateEdgeSupport4(long uID, long PlateNum, long EdgeNum, long CaseNum,

long* Status, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

Strand7 API Manual

EdgeNum

Edge number; one of 1, 2, 3 or 4.

CaseNum

Freedom case number.

Output Parameters
Status[0..1]

[0] –  Compression-only support; either btTrue or btFalse.

[1] –  Limited bearing capacity; either btTrue or btFalse.

Doubles[0..3]

[0] – Elastic support value in the normal direction.

[1] – Elastic support value in the lateral direction.

[2] – Support gap.  Only relevant if Status[0] is set to btTrue.

[3] – Bearing capacity.  Only relevant if Status[1] is set to btTrue.
