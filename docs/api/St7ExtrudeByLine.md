# St7ExtrudeByLine

Extrudes selected entities along a line.

long St7ExtrudeByLine(long uID, long CollectionID, long Divisions,
long Direction, double RotationAngle, double RadialScale)
Input Parameters
uID
Strand7 model file ID.
CollectionID
The ID of a collection of entities returned by a previous call to St7DefineEntityCollection that defines the
line of extrusion. The collection must contain beams that are joined end-to-end.
Divisions
The number of evenly spaces divisions along the line, or 0 to divide the extrusions at the nodes as
defined in the line definition.
Direction
Either ldAuto, to extrude along the line starting from the end closest to the selected elements, or
ldReversed, to extrude the other direction.
RotationAngle
The source entities are progressively rotated about the axis of the line of extrusion such that the total
rotation at the end of the extrusion equals the specified rotation angle (degrees). A zero rotation angle
produces a parallel extrusion whereas a non-zero rotation angle produces a helical extrusion.
RadialScale
The source entities are progressively scaled radially with respect to the axis of the line of extrusion such
that at the end of the extrusion they are scaled radially by the specified radial scale. A radial scale of 1.0
produces a parallel extrution whereas a non-unit radial scale produces a tapered extrusion.
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
