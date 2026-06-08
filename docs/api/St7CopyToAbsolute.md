# St7CopyToAbsolute

Copies selected entities to a fixed ordinate in a given axis of a coordinate system.

Strand7 API Manual

long St7CopyToAbsolute(long uID, double Value, long UCSId, long Axis)

Input Parameters

uID

Strand7 model file ID.

Value

Value of ordinate adjusted by copy operation.

UCSId

The coordinate system into which the copy will occur.

Axis

The axis in the coordinate system; one of 1, 2 or 3.

Dependencies
Selection

Entities can be selected using functions in Entity Selection.

Property Increment

Assigned using St7SetPropertyIncrement.

Copy Flags

Assigned using St7SetCopyFlags.

Keep Selected

Assigned using St7SetKeepSelect.

Tools – Move

Tools – Move
