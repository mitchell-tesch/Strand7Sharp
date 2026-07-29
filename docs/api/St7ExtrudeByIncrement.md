# St7ExtrudeByIncrement

Extrudes selected entities by increment.

long St7ExtrudeByIncrement(long uID, double* DXYZ, long UCSId, long NumCopies)
Input Parameters
uID
Strand7 model file ID.
DXYZ[0..2]
Increment.
UCSId
UCS in which increment has been provided.
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
