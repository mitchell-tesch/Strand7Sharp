# St7GetElementCoordinatesAtBirth

Returns the coordinates of the nodes of the specified element in its birth position when a result file is open.

long St7GetElementCoordinatesAtBirth(long uID, long Entity, long EntityNum,

long ResultCase, double* XYZ)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyBEAM, tyPLATE or tyBRICK.

EntityNum

Entity number.

ResultCase

Result case number.

Output Parameters
XYZ[0..3*N-1]

The global Cartesian coordinates of N nodes as an array. The first three values in the array refer to the
first node, the next three to the second node, and so on. The array must be long enough to cater for the
number of nodes on the element. The maximum array length will be 60 to cater for a 20-node brick
element.

Usage

The birth coordinates will be the same as the initial coordinates for an element that is not morphed.  For a
morphed element, the birth coordinates can change from result case to result case depending on the staging
history of the element.
