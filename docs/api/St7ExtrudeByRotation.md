# St7ExtrudeByRotation

Extrudes selected entities by rotation.

long St7ExtrudeByRotation(long uID, long UCSId, long Axis, double Angle,
double* Origin, long NumCopies)
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
NumCopies
Number of repeats.
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
