# St7DefinePlaneGlobalN

Creates a new plane definition by locating one of the three global XYZ planes at a node.

long St7DefinePlaneGlobalN(long uID, long NodeNum, long Plane, long* PlaneID)
Input Parameters
uID
Strand7 model file ID.
NodeNum
Number of a node that lies on the plane being defined.
Plane
Plane number, 1, 2 or 3 for the XY, YZ or ZX plane respectively.
Output Parameters
PlaneID
Plane identifier.
