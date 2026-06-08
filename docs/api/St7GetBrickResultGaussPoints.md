# St7GetBrickResultGaussPoints

Returns the position of the result Gauss points for the specified brick.

Strand7 API Manual

long St7GetBrickResultGaussPoints(long uID, long BrickNum, long ResultCase,

long* NumGauss, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BrickNum

Brick number.

ResultCase

Result case number.

Output Parameters
NumGauss

Number of Gauss points.

Doubles[0..80]

[0..3*NumGauss-1] – An array containing the global XYZ coordinates of the result Gauss points. The
positions are returned in blocks of length 3, with the position of the ith point starting at
Doubles[(i-1)*3].
