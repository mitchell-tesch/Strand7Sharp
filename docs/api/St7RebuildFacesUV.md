# St7RebuildFacesUV

Redefines the parametric space of NURBS geometry faces to improve mesh quality using specified parameters.

long St7RebuildFacesUV(long uID, long DegreeU, long DegreeV, long ControlPointsU,
long ControlPointsV)
Input Parameters
uID
Strand7 model file ID.
DegreeU
Degree of the surface defining polynomial in the u direction.

DegreeV
Degree of the surface defining polynomial in the v direction.
ControlPointsU
Number of control points in the u direction.
ControlPointsV
Number of control points in the v direction.
Dependencies
Selection
Entities can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
Global Parameters
ivFacesChanged, ivFacesFailed.
