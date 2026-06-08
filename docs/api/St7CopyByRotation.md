# St7CopyByRotation

Copies selected entities by rotation.

long St7CopyByRotation(long uID, long UCSId, long Axis, double Angle,

double* Origin, long NumCopies)

Input Parameters

uID

Strand7 model file ID.

UCSId

UCS in which axis of rotation is defined.

Tools – Copy

Axis

Axis of rotation; one of 1, 2 or 3.

Angle

Rotation increment (degrees).

Origin[0..2]

Rotation origin.

NumCopies

Number of copies.

Dependencies
Selection

Entities can be selected using functions in Entity Selection.

Property Increment

Assigned using St7SetPropertyIncrement.

Copy Flags

Assigned using St7SetCopyFlags.

Keep Selected

Assigned using St7SetKeepSelect.
