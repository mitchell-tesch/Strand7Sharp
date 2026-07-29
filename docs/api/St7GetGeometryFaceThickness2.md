# St7GetGeometryFaceThickness2

Returns the thickness assigned to the specified geometry face.

long St7GetGeometryFaceThickness2(long uID, long FaceNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.

FaceNum
Face number.
Output Parameters
Doubles[0..1]
[0] – Membrane thickness.
[1] – Bending thickness.
