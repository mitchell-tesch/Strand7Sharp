# St7ExtrudeToAbsolute

Extrudes selected entities to a fixed ordinate in a given axis of a coordinate system.

long St7ExtrudeToAbsolute(long uID, double Value, long UCSId, long Axis)

Input Parameters

uID

Strand7 model file ID.

Value

Value of ordinate adjusted by extrude operation.

UCSId

The coordinate system into which the extrusion will occur.

Axis

The axis in the coordinate system; one of 1, 2 or 3.

Dependencies
Selection

Entities can be selected using functions in Entity Selection.

Property Increment

Assigned using St7SetPropertyIncrement.

Source Action

Assigned using St7SetSourceAction.

Extrusion Targets

Assigned using St7SetExtrudeTargets.

Extrusion Flags

Assigned using St7SetExtrudeFlags.

Keep Selected

Assigned using St7SetKeepSelect.

Tools – Extrude

Default Group

Target group for nodes extruded into beams is specified by St7SetDefaultGroupID; for other targets the
group is inherited.

Strand7 API Manual

Tools – Scale
