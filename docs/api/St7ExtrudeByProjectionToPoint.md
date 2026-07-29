# St7ExtrudeByProjectionToPoint

Extrudes selected entities by projection to a point specified by coordinates.

long St7ExtrudeByProjectionToPoint(long uID, double* Point)
Input Parameters
uID
Strand7 model file ID.
Point[0..2]
The point to which the extrusion will occur, in the global XYZ system.
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
Default Group
Target group for nodes extruded into beams is specified by St7SetDefaultGroupID; for other targets the
group is inherited.
