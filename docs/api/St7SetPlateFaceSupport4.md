# St7SetPlateFaceSupport4

Sets the elastic face support value for the specified plate.

long St7SetPlateFaceSupport4(long uID, long PlateNum, long Surface, long CaseNum,

long* Status, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

Surface

Plate surface; either psPlateMinusZ or psPlatePlusZ.

CaseNum

Freedom case number.

Status[0..1]

[0] –  Compression-only support; either btTrue or btFalse.

[1] –  Limited bearing capacity; either btTrue or btFalse.

Doubles[0..3]

[0] – Elastic support value in the normal direction.

[1] – Elastic support value in the lateral direction.

[2] – Support gap.  Only relevant if Status[0] is set to btTrue.

[3] – Bearing capacity.  Only relevant if Status[1] is set to btTrue.
