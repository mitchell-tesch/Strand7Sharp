# St7SetPlatePointMoment6

Assigns a point moment to the specified plate.

long St7SetPlatePointMoment6(long uID, long PlateNum, long CaseNum,
long Position, long ID, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number.
CaseNum
Load case number.
Position
Position identifier; either axUCS or axLocal.
ID
Local ID number for the point moment.
Doubles[0..5]
[0..2] – Components of the applied moment in the global XYZ system.
Where Position is axUCS:
[3..5] – XYZ position of the point moment in global XYZ coordinates.
Where Position is axLocal:
[3..4] – uv position of point moment in the local element coordinate system.
