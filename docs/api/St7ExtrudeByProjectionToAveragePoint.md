# St7ExtrudeByProjectionToAveragePoint

Extrudes selected entities by projection to a point. The point is calculated as the average of all selected nodes and
all nodes in the set of selected elements.

long St7ExtrudeByProjectionToAveragePoint(long uID)
Input Parameters
uID
Strand7 model file ID.
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
