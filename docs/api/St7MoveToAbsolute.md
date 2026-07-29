# St7MoveToAbsolute

Moves selected entities to a fixed ordinate in a given axis of a coordinate system.

long St7MoveToAbsolute(long uID, double Value, long UCSId, long Axis)
Input Parameters
uID
Strand7 model file ID.
Value
Value of ordinate adjusted by move operation.
UCSId
The coordinate system into which the move will occur.
Axis
The axis in the coordinate system; one of 1, 2 or 3.
Dependencies
Selection
Entities can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
