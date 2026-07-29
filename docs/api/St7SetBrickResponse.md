# St7SetBrickResponse

Assigns a response variable to the specified brick.

long St7SetBrickResponse(long uID, long BrickNum, long CaseNum, long UCSId,
long* Status)
Input Parameters
uID
Strand7 model file ID.
BrickNum
Brick number.
CaseNum
Load case number.
UCSId
0 to use the local axis system of the brick, or the ID number of the specified UCS. UCSId = 1 refers to the
global XYZ system.

Status[0..5]
A 6-element array describing the stress components that are flagged as response variables according to
the 123 axis convention in the specified UCS, [11, 22, 33, 12, 23, 31].
