# St7SplitFaceByPlane

Splits a geometry face at a plane.

Tools – Geometry

long St7SplitFaceByPlane(long uID, long PlaneID, long NumCutFaces,

long NumRepeats, double Increment)

Input Parameters

uID

Strand7 model file ID.

PlaneID

The ID of a plane at which to cut faces.  Functions in Tools – Plane Definition are used to define a plane
and return the PlaneID.

NumCutFaces

Number of faces to create at the cut; one of 0, 1 or 2. If two faces are requested, the generated faces
will have opposing normals.

NumRepeats

Number of repeated cuts to make using parallel planes offset from that specified by PlaneID.

Increment

Offset increment for repeated planes, in the positive Z direction from the plane specified by PlaneID.

Dependencies

Keep Selected

Assigned using St7SetKeepSelect.

Default Group

Target group for the cut faces is specified by St7SetDefaultGroupID.

Global Parameters

ivSeamsAdded, ivIntersectionsFound, ivFacesChanged, ivFacesCreated,
ivFacesFailed.
