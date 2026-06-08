# St7MoveToOriginByPoint

Moves selected entities by shifting a reference point to the origin of a coordinate system.

long St7MoveToOriginByPoint(long uID, long UCSId, double* Point)

Input Parameters

uID

Strand7 model file ID.

UCSId

The coordinate system specifying the minimum point.

Point[0..2]

The reference point that will be located at the origin.

Dependencies
Selection

Entities can be selected using functions in Entity Selection.

Strand7 API Manual

Keep Selected

Assigned using St7SetKeepSelect.
