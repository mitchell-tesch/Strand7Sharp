# St7GetBXSLoop

Returns the coordinates of the points in the specified loop of a BXS. The points are always specified in a 2D plane.
Use St7GetNumBXSLoopPoints to determine the number of points in a loop.

long St7GetBXSLoop(long uID, long PropNum, long LoopNum, long MaxPoints,

long* NumPoints, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

The BXS property number.

LoopNum

The loop number.

MaxPoints

The maximum number of points allocated in Doubles; returns all points if set greater than or equal to
NumPoints.

Output Parameters
NumPoints

The number of points in the specified loop.

Doubles[0..2*MaxPoints-1]

An array containing the XY coordinates of the points in the loop. The XY coordinates of point i are
contained in Doubles[2*i-2..2*i-1].
