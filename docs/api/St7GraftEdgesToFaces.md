# St7GraftEdgesToFaces

Grafts edges to geometry faces.

long St7GraftEdgesToFaces(long uID, long DistanceType, double Distance)
Input Parameters
uID
Strand7 model file ID.
DistanceType
Specifies how the Distance is to be interpreted; either ztRelative or ztAbsolute.
Distance
The graft tolerance. Edges that are closer to geometry faces than this tolerance will be grafted onto
them.
Dependencies
Selection
Entities can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
Global Parameters
ivSeamsAdded, ivIntersectionsFound, ivFacesChanged, ivFacesCreated,
ivFacesFailed.
