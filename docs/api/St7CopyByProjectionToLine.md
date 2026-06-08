# St7CopyByProjectionToLine

Copies selected entities by projection to a predefined line.

long St7CopyByProjectionToLine(long uID, long LineID, bool EquiSpace)

Input Parameters

uID

Strand7 model file ID.

LineID

The ID of a line to which the selected entities will be projected.  Functions in Tools – Line Definition are
used to define a line and return the LineID.

EquiSpace

Equal spacing between nodes projected to the line.

Dependencies
Selection

Entities can be selected using functions in Entity Selection.

Strand7 API Manual

Property Increment

Assigned using St7SetPropertyIncrement.

Direction

Assigned by the most recent call to a function in Tools – Projection Direction.

Copy Flags

Assigned using St7SetCopyFlags.

Keep Selected

Assigned using St7SetKeepSelect.
