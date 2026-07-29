# St7MoveByRotation

Moves selected entities by rotation.

long St7MoveByRotation(long uID, long UCSId, long Axis, double Angle,
double* Origin)
Input Parameters
uID
Strand7 model file ID.
UCSId
UCS in which axis of rotation is defined.
Axis
Axis of rotation; one of 1, 2 or 3.
Angle
Rotation increment (degrees).
Origin[0..2]
Rotation origin.

Dependencies
Selection
Entities can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
