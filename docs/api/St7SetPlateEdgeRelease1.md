# St7SetPlateEdgeRelease1

Sets the edge release conditions for the specified plate.

long St7SetPlateEdgeRelease1(long uID, long PlateNum, long EdgeNum, long* Status)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number.
EdgeNum
Edge number; one of 1, 2, 3 or 4.
Output Parameters
Status[0]
Release status; either prReleased or prFixed.
