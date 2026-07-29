# St7ExtrudeByThickness

Extrudes selected entities by thickness.

long St7ExtrudeByThickness(long uID, double Thickness, long BeamDir,
long PlateSurface, bool UsePlateThickness, bool SourceMidPlane)
Input Parameters
uID
Strand7 model file ID.
Thickness
Distance to extrude.
BeamDir
Direction to extrude beams in their principal axis system; either 1 or 2.
PlateSurface
Direction to extrude plates if UsePlateThickness is True; either psPlateMinusZ or psPlatePlusZ.
UsePlateThickness
True to base the increment on the thickness of the plate.
SourceMidPlane
True to extrude half the thickness on each side, producing a single element centred on the source’s mid-
plane.
Dependencies
Selection
Entities can be selected using functions in Entity Selection.
Property Increment
Assigned using St7SetPropertyIncrement.
Extrusion Targets
Assigned using St7SetExtrudeTargets.
Extrusion Flags
Assigned using St7SetExtrudeFlags.
Source Action
Assigned using St7SetSourceAction.

Keep Selected
Assigned using St7SetKeepSelect.
