# St7SetPlateThickness2

Sets the thickness attribute of the specified plate element, overriding the plate property thickness – see
St7SetPlateThickness to set the plate property thickness.

long St7SetPlateThickness2(long uID, long PlateNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Plate Attributes – Set

PlateNum

Plate number.

Doubles[0..1]

[0] – Membrane thickness of the plate.

[1] – Bending thickness of the plate.
