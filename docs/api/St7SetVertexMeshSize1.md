# St7SetVertexMeshSize1

Assigns a desired mesh size at the specified vertex. This value is used to control the local mesh resolution when
using the surface automeshing tools.

long St7SetVertexMeshSize1(long uID, long VertexNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
VertexNum
Vertex number.

Doubles[0]
Desired mesh size at the specified vertex. This value is used to determine the desired edge length of
adjacent plate elements generated during surface auto-meshing.
