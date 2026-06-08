# St7GetPlateXAngle1

Returns the local axis angle for the specified plate. This angle controls the rotations of the plate local xy axes
about the local z axis.

long St7GetPlateXAngle1(long uID, long PlateNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

Output Parameters
Doubles[0]

The angle describing the rotation of the plate local axis system about the local z axis. See Plate Local
Coordinates for additional information.
