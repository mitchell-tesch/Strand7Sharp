# St7CreateBeamsOnElementEdges

Creates beams on selected plate edges and brick faces.

long St7CreateBeamsOnElementEdges(long uID, long PropNum, long QuadraticAs,
long BasedOn, double FacetAngle, bool FreeEdges, bool TJunctions,
bool PropBoundary, bool GroupBoundary, bool InternalBricks)
Input Parameters
uID
Strand7 model file ID.
PropNum
Property number of created beams.
QuadraticAs
One of eeSplit, eeIgnoreMid or eeBeam3.
BasedOn
Either beBasedOnModel or beBasedOnSelected.
FacetAngle
Angle (degrees).
FreeEdges
True to apply to free edges.
TJunctions
True to apply to T-junctions.
PropBoundary
True to apply property boundaries.
GroupBoundary
True to apply to group boundaries.

InternalBricks
True to apply to internal brick edges. If FacetAngle=0, DoTJunctions=True and DoInternalBricks=True, a
beam will be created on every edge of every selected brick.
Dependencies
Selection
Plate edges and brick faces can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
