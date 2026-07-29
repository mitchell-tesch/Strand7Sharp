# St7GetElementCentroidAtBirth

Returns the coordinates of the geometric centroid of the specified element in its birth position when a result file is
open.

long St7GetElementCentroidAtBirth(long uID, long Entity, long EntityNum,
long FaceEdgeNum, long ResultCase, double* XYZ)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyBEAM, tyPLATE or tyBRICK.
EntityNum
Entity number.
FaceEdgeNum
Local face or edge number; one of 0, 1, 2, 3 or 4 for tyPLATE or 0, 1, 2, 3, 4, 5 or 6 for tyBRICK. Enter 0 to
return the centroid of the whole element. See Element Connections for additional information.
ResultCase
Result case number.

Output Parameters
XYZ[0..2]
The global Cartesian coordinates of the centroid as a 3-element array.
