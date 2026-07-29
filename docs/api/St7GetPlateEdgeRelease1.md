# St7GetPlateEdgeRelease1

Returns the edge release condition for the specified plate edge.

long St7GetPlateEdgeRelease1(long uID, long PlateNum, long EdgeNum, long* Status)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number.
EdgeNum
Local edge number; one of 1, 2, 3 or 4.
Output Parameters
Status[0]
Release status; either prReleased or prFixed.
