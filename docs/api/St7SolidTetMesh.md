# St7SolidTetMesh

Performs a solid meshing operation based on the surface mesh definitions included in the specified Strand7
model. Surface mesh definitions can be created using the St7SurfaceMesh function, but may also be created by
other means.

long St7SolidTetMesh(long uID, long* Integers, long Mode)
Input Parameters
uID
Strand7 model file ID.
Integers[0..12]
[ipTetraMeshSize] – Mesh size control for internal elements; one of msFine, msMedium or
msCoarse.
[ipTetraMeshProperty] – Brick property number.
[ipTetraMeshInc] – Brick property number increment for separate solid parts.
[ipTetraMesh10] – Mesh using Tetra10 elements; either btTrue or btFalse.
[ipTetraMeshGroupsAsSolids] – Mesh groups as solids; either btTrue or btFalse.
[ipTetraMeshSmooth] – Smooth tetra elements after meshing; either btTrue or btFalse.
[ipTetraMeshAutoCreateProperties] – Create brick properties as needed; either btTrue or
btFalse.
[ipTetraMeshDeletePlates] – Delete surface plates after meshing; either btTrue or btFalse.
[ipTetraMeshAllowUserStop] – Allow the user to terminate the meshing process; either btTrue or
btFalse.
[ipTetraMeshCheckSelfIntersect] – Check for initial self intersections in the surface plate mesh;
either btTrue or btFalse.
[ipTetraMeshZipOption] – Zip option for adjacent solids; one of tmAutoZipMultipleSolids,
tmUserZipMultipleSolids or tmDontZipMultipleSolids.

Mode
Controls the display of a progress bar; either ieQuietRun or ieProgressRun.
Global Parameters
ivSolidsMeshed, ivSolidsPartiallyMeshed, ivSolidsNotMeshed.
