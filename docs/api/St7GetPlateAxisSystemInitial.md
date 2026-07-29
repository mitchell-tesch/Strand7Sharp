# St7GetPlateAxisSystemInitial

Returns the plate axis system for the specified plate element based on the initial node coordinates. See Plate
Local Coordinates for additional information.

long St7GetPlateAxisSystemInitial(long uID, long PlateNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number.
Output Parameters
Doubles[0..8]
[0..2] – A unit vector in the global XYZ system, defining the local x direction of the plate.
[3..5] – A unit vector in the global XYZ system, defining the local y direction of the plate.
[6..8] – A unit vector in the global XYZ system, defining the local z direction of the plate.
