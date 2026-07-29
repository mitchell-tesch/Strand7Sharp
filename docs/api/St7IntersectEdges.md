# St7IntersectEdges

Intersects the edges of geometry faces placing a vertex at the intersection point.

long St7IntersectEdges(long uID, long DistanceType, double Distance,
bool SplitFaces)
Input Parameters
uID
Strand7 model file ID.
DistanceType
Specifies how the Distance is to be interpreted; either ztRelative or ztAbsolute.
Distance
The edge tolerance. Edges that are closer than this tolerance will be split.

SplitFaces
True to split faces along their intersection.
Dependencies
Selection
Entities can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
Global Parameters
ivSeamsAdded, ivIntersectionsFound, ivFacesChanged, ivFacesCreated,
ivFacesFailed.
