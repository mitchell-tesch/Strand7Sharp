# St7DefinePlaneGlobalV

Creates a new plane definition by locating one of the three global XYZ planes at a vertex.

long St7DefinePlaneGlobalV(long uID, long VertexNum, long Plane, long* PlaneID)

Input Parameters

uID

Strand7 model file ID.

VertexNum

Number of a vertex that lies on the plane being defined.

Plane

Plane number, 1, 2 or 3 for the XY, YZ or ZX plane respectively.

Output Parameters

PlaneID

Plane identifier.

Tools – Plane Definition
