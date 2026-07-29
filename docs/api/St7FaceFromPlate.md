# St7FaceFromPlate

Converts one or more plate elements to geometric faces.

long St7FaceFromPlate(long uID, bool NodeAttribToVertices,
bool PlateAttribToFaces, bool CircularFaceEdges)
Input Parameters
uID
Strand7 model file ID.
NodeAttribToVertices
True to pass on Node Attributes to Vertices.
PlateAttribToFaces
True to pass on Plate Attributes to Faces.

CircularFaceEdges
True to create Circular Face Edges, False to create Quadratic Face Edges. Note that circular face edges
are inferred from mid-side nodes for singly curved plates only.
Dependencies
Selection
Plates can be selected using functions in Entity Selection.
Source Action
Erase or keep plates, depending on St7SetSourceAction.
Keep Selected
Assigned using St7SetKeepSelect.
Global Parameters
ivFacesCreated, ivTessellationsFailed.
