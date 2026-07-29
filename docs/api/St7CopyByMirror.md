# St7CopyByMirror

Copies selected entities by reflecting them over a predefined plane.

long St7CopyByMirror(long uID, long PlaneID)
Input Parameters
uID
Strand7 model file ID.
PlaneID
The ID of a plane over which the selected entities will be mirrored. Functions in Tools – Plane Definition
are used to define a plane and return the PlaneID.
Dependencies
Selection
Entities can be selected using functions in Entity Selection.
Property Increment
Assigned using St7SetPropertyIncrement.
Copy Flags
Assigned using St7SetCopyFlags.
Keep Selected
Assigned using St7SetKeepSelect.
