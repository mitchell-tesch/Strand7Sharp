# St7SetGeometryFaceSupport4

Assigns an elastic support condition to the specified geometry face.

long St7SetGeometryFaceSupport4(long uID, long FaceNum, long Surface,
long CaseNum, long* Status, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
FaceNum
Face number.
Surface
Face surface; either psPlateMinusZ or psPlatePlusZ.
CaseNum
Freedom case number.
Status[0..1]
[0] – Compression-only support; either btTrue or btFalse.
[1] – Limited bearing capacity; either btTrue or btFalse.
Doubles[0..3]
[0] – Elastic support value in the normal direction.

[1] – Elastic support value in the lateral direction.
[2] – Support gap. Only relevant if Status[0] is set to btTrue.
[3] – Bearing capacity. Only relevant if Status[1] is set to btTrue.
