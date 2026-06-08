# St7MeshFromLoops

Performs a surface meshing operation on a single face. The definition of this face is specified explicitly using the
array inputs for this function.

long St7MeshFromLoops(long uID, long* Integers, double* Doubles, long* Loops,

double* Points, long Mode)

Input Parameters

uID

Strand7 model file ID.

Integers[0..3]

[ipMeshTargetNodes] – Number of nodes in the target element; one of 3, 4, 6 or 8.

[ipMeshTargetPropertyID] – Plate property number for new elements.

[ipMeshUCSID] – UCS ID number onto which the polygon is projected.

[ipMeshGroupID] – Group ID number for new elements.

Doubles[0..0]

[ipMeshPositionUCS] – Location of the elements on the UCS 3 axis.

Loops[..]

[0] – the total number of loops in the polygon.

Tools – Mesh

[1] – the number of points in the first loop in the polygon. This loop is always the outer loop.

[2..1+Loops[1]] – a list of point indices defining the first loop.

[2+Loops[1]] – the number of points in the second loop of the polygon.

Then recursively, where Loops[k] contains the number of points in the ith loop,

[k+1..k+Loops[k]] – contains a list of point indices defining the ith loop

[k+Loops[k]+1] contains the number of points in the (i+1)th loop.

Points[..]

A list of the XY coordinates for the polygon points, with the X and Y coordinates stored contiguously.

[2*j-2] – the X coordinate of point j.

[2*j-1] – the Y coordinate of point j.

Mode

Controls the display of a progress bar; either ieQuietRun or ieProgressRun.
