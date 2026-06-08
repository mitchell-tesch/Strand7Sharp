# St7ExtrudeByProjectionToLine

Extrudes selected entities by projection to a predefined line.

long St7ExtrudeByProjectionToLine(long uID, long LineID, bool EquiSpace)

Input Parameters

uID

Strand7 model file ID.

LineID

The ID of a line to which the selected entities will be projected.  Functions in Tools – Line Definition are
used to define a line and return the LineID.

EquiSpace

True to produce equal spacing between nodes projected to the line.

Dependencies
Selection

Entities can be selected using functions in Entity Selection.

Property Increment

Assigned using St7SetPropertyIncrement.

Direction

Assigned by the most recent call to a function in Tools – Projection Direction.

Tools – Extrude

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
