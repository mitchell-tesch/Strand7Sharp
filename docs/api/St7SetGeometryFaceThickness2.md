# St7SetGeometryFaceThickness2

Assigns a thickness to the specified geometry face. This value is constant over the surface.

long St7SetGeometryFaceThickness2(long uID, long FaceNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
FaceNum
Face number.

Doubles[0..1]
[0] – Membrane thickness.
[1] – Bending thickness.
