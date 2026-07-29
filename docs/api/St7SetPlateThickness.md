# St7SetPlateThickness

Sets the thickness for the specified plate property.

long St7SetPlateThickness(long uID, long PropNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.

PropNum
Plate property number.
Doubles[0..1]
[0] – Plate membrane thickness.
[1] – Plate bending thickness.
