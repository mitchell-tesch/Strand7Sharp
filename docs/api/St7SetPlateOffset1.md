# St7SetPlateOffset1

Sets the offset for the specified plate element. The offset is applied according to the plate local z axis direction
and is uniform over the element surface.

long St7SetPlateOffset1(long uID, long PlateNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

Doubles[0]

Plate offset in the local z axis direction.
