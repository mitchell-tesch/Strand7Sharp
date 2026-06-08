# St7GetPlateThickness2

Returns the thickness attribute of the specified plate, if the thickness attribute is set – see St7GetPlateThickness to
get the default plate property thickness.

Plate Attributes – Get

long St7GetPlateThickness2(long uID, long PlateNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

Output Parameters
Doubles[0..1]

[0] – Plate membrane thickness.

[1] – Plate bending thickness.
