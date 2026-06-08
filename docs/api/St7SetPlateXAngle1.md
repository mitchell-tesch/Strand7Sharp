# St7SetPlateXAngle1

Sets the local axis angle for the specified plate. This angle controls the rotation of the plate local xy axes about the
local z axis.

long St7SetPlateXAngle1(long uID, long PlateNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

Doubles[0]

The angle describing the rotation of the plate local axis system about the local z axis. See Plate Local
Coordinates for additional information.
