# St7ExtrudeByProjectionToPlane

Extrudes selected entities by projection to a predefined plane.

long St7ExtrudeByProjectionToPlane(long uID, long PlaneID)
Input Parameters
uID
Strand7 model file ID.
PlaneID
The ID of a plane to which the selected entities will be projected. Functions in Tools – Plane Definition
are used to define a plane and return the PlaneID.
Dependencies
Selection
Entities can be selected using functions in Entity Selection.
Property Increment
Assigned using St7SetPropertyIncrement.
Direction
Assigned by the most recent call to a function in Tools – Projection Direction.
Source Action
Assigned using St7SetSourceAction.
Extrusion Targets
Assigned using St7SetExtrudeTargets.

Extrusion Flags
Assigned using St7SetExtrudeFlags.
Keep Selected
Assigned using St7SetKeepSelect.
Default Group
Target group for nodes extruded into beams is specified by St7SetDefaultGroupID; for other targets the
group is inherited.
