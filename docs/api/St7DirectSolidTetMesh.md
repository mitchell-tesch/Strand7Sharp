# St7DirectSolidTetMesh

Performs a solid meshing operation based on the geometry included in the specified Strand7 model.  Effectively,
the function combines the functionality provided by a call to St7SurfaceMesh followed by a call St7SolidTetMesh
to produce a solid mesh directly from the geometry, bypassing the explicit generation of surface plate elements.

long St7DirectSolidTetMesh(long uID, long* Integers, double* Doubles, long Mode)

Input Parameters

uID

Strand7 model file ID.

Integers[0..12]

[ipDirectTetraMeshMode] – Meshing mode; either mmAuto or mmCustom.

[ipDirectTetraMeshSizeMode] – Mesh size option; either smPercentage or smAbsolute.

[ipDirectTetraMinEdgesPerCircle] – Minimum number of edges per circular edge.

[ipDirectTetraApplyTransitioning] – Apply edge transitioning when placing boundary nodes;
either btTrue or btFalse.

[ipDirectTetraApplySurfaceCurvature] – Consider surface curvature when placing boundary
nodes; either btTrue or btFalse.

[ipDirectTetraAllowUserStop] – Allow the user to terminate the meshing process; either btTrue
or btFalse.

[ipDirectTetraConsiderNearVertex] – Allow automesher to base element size on vertices near
to, but not on, a surface; either btTrue or btFalse.

[ipDirectTetraMeshSelectedGroups] – btTrue to mesh only the groups with at least one
selected face, otherwise all groups are meshed.

[ipDirectTetraMeshSize] – Mesh size control for internal elements; one of msFine, msMedium or
msCoarse.

[ipDirectTetraMesh10] – Mesh using Tetra10 elements; either btTrue or btFalse.

[ipDirectTetraMeshSmooth] – Smooth tetra elements after meshing; either btTrue or btFalse.

[ipDirectTetraAutoCreateProperties] – Create brick properties as needed; either btTrue or
btFalse.

[ipDirectMeshZipOption] – Zip option for adjacent solids; one of tmAutoZipMultipleSolids,
tmUserZipMultipleSolids or tmDontZipMultipleSolids.

Strand7 API Manual

Doubles[0..3]

[ipSurfaceMeshSize] – Mesh size, scaled based on Integers[ipDirectTetraMeshSizeMode].

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

Faces can be selected using functions in Entity Selection.  Only applicable if
Integers[ipDirectTetraMeshSelectedGroups] is btTrue.

Global Parameters

ivFacesMeshed, ivFacesPartiallyMeshed, ivFacesNotMeshed, ivSolidsMeshed,
ivSolidsPartiallyMeshed, ivSolidsNotMeshed.
