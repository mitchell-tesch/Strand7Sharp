# St7GetPlateResultGaussPoints

Returns the position of the result Gauss points for the specified plate.

long St7GetPlateResultGaussPoints(long uID, long PlateNum, long ResultCase,
long* NumGauss, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number.
ResultCase
Result case number.
Output Parameters
NumGauss
Number of Gauss points.
Doubles[0..26]
[0..3*NumGauss-1] – An array containing the global XYZ coordinates of the result Gauss points. The
positions are returned in blocks of length 3, with the position of the ith point starting at
Doubles[(i-1)*3].
