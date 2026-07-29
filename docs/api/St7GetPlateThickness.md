# St7GetPlateThickness

Returns the thickness assigned to the specified plate property.

long St7GetPlateThickness(long uID, long PropNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Plate property number.
Output Parameters
Doubles[0..1]
[0] – Plate membrane thickness.
[1] – Plate bending thickness.
