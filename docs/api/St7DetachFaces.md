# St7DetachFaces

Detach selected geometry faces.

long St7DetachFaces(long uID, long DetachMode)
Input Parameters
uID
Strand7 model file ID.
DetachMode
One of dmDetachIndividual, for Individual faces, dmDetachAsCluster, for Clusters of faces or
dmDetachGroups for Clusters of groups.
Dependencies
Selection
Faces can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
Global Parameters
ivFacesChanged.
