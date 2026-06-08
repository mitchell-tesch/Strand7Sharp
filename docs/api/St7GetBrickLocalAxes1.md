# St7GetBrickLocalAxes1

Returns the UCS used as the local axis system for the specified brick.

long St7GetBrickLocalAxes1(long uID, long BrickNum, long* UCSId)

Input Parameters

uID

Strand7 model file ID.

BrickNum

Brick number.

Output Parameters

UCSId

ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.
