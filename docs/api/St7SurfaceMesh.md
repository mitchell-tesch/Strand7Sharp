# St7SurfaceMesh

Performs a surface meshing operation based on the geometry included in the specified Strand7 model.

long St7SurfaceMesh(long uID, long* Integers, double* Doubles, long Mode)
Input Parameters
uID
Strand7 model file ID.
Integers[0..10]
[ipSurfaceMeshMode] – Meshing mode; either mmAuto or mmCustom.
[ipSurfaceMeshSizeMode] – Mesh size option; either smPercentage or smAbsolute.
[ipSurfaceMeshTargetNodes] – Number of nodes in target element; one of 3, 4, 6 or 8.
[ipSurfaceMeshTargetPropertyID] – Element property definition; one of -1 to use the face
property, 0 to use the face number or >0 to use a constant property.
[ipSurfaceMeshAutoCreateProperties] – Create properties as needed; either btTrue or btFalse.
[ipSurfaceMeshMinEdgesPerCircle] – Minimum number of edges per circular edge.
[ipSurfaceMeshApplyTransitioning] – Apply edge transitioning when placing boundary nodes;
either btTrue or btFalse.
[ipSurfaceMeshApplySurfaceCurvature] – Consider surface curvature when placing boundary
nodes; either btTrue or btFalse.
[ipSurfaceMeshAllowUserStop] – Allow the user to terminate the meshing process; either btTrue
or btFalse.
[ipSurfaceMeshConsiderNearVertex] – Allow automesher to base element size on vertices near
to, but not on, a surface; either btTrue or btFalse.
[ipSurfaceMeshSelectedFaces] – btTrue to mesh only the selected faces, otherwise all faces are
meshed.
Doubles[0..3]
[ipSurfaceMeshSize] – Mesh size, scaled based on Integers[ipSurfaceMeshSizeMode].
[ipSurfaceMeshLengthRatio] – Maximum allowable ratio between the largest and smallest edge
on each face.
[ipSurfaceMeshMaximumIncrease] – Rate of increase in edge length between neighbouring
elements, in the range 0 to 1.
[ipSurfaceMeshOnEdgesLongerThan] – Minimum curve length on which the Min Edges per Circle
parameter is to be used.

Mode
Controls the display of a progress bar; either ieQuietRun or ieProgressRun.
Dependencies
Selection
Faces can be selected using functions in Entity Selection. Only applicable if
Integers[ipSurfaceMeshSelectedFaces] is btTrue.
Global Parameters
ivFacesMeshed, ivFacesPartiallyMeshed, ivFacesNotMeshed.
