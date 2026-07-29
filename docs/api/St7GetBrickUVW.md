# St7GetBrickUVW

Returns the local brick uvw coordinates corresponding to a global XYZ position. The XYZ position should be located
approximately within the brick.

long St7GetBrickUVW(long uID, long BrickNum, double* XYZ, double* UVW)
Input Parameters
uID
Strand7 model file ID.
BrickNum
Brick number.
XYZ[0..2]
A 3-element array containing the global XYZ coordinates of the point.
Output Parameters
UVW[0..2]
A 3-element array containing the local brick uvw coordinates. See Brick Local Coordinates for additional
information.
