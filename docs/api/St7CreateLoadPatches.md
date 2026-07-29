# St7CreateLoadPatches

Creates Load Patch plate elements on selected beam frameworks.

long St7CreateLoadPatches(long uID, double PlaneTol, bool TriangularLoad,
bool UseBeamGroup)
Input Parameters
uID
Strand7 model file ID.
PlaneTol
Angular tolerance (degrees); the tool ignores adjacent beam segments that exceed this tolerance.
TriangularLoad
True to apply triangular loads on load patch polygons with five or more edges.
False to apply a constant load on load patch polygons with five or more edges.
UseBeamGroup
True to assign plate elements to the same group as their surrounding beam elements.
False to assign plate elements to the default group.
Dependencies
Selection
Beams can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
