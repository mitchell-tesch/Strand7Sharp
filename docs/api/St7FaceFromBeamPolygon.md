# St7FaceFromBeamPolygon

Converts one or more beam polygons to geometric faces.

long St7FaceFromBeamPolygon(long uID, long FaceNum, long PropNum, double EdgeTol,
bool BeamPropAsLoop, bool BeamGroupAsLoop)
Input Parameters
uID
Strand7 model file ID.
FaceNum
Face number of target face, or 0 to project to average plane.
PropNum
Plate property number for new faces.
EdgeTol
Angular tolerance between adjacent polygon edges (degrees). Edges within tolerance may be smoothed
via curve fitting.
BeamPropAsLoop
True to operate on each beam property separately.
BeamGroupAsLoop
True to operate on each group separately.
Dependencies
Selection
Beams can be selected using functions in Entity Selection.

Source Action
Erase or keep beams, depending on St7SetSourceAction.
Keep Selected
Assigned using St7SetKeepSelect.
Default Group
Target group for the faces is specified by St7SetDefaultGroupID.
Global Parameters
ivFacesCreated, ivTessellationsFailed.
