# St7SetGeometryEdgeType

Sets the type for the specified geometry edge. This determines how its attributes are inherited by elements
created by the automesher.

long St7SetGeometryEdgeType(long uID, long EdgeNum, long EdgeType)
Input Parameters
uID
Strand7 model file ID.
EdgeNum
Edge number.
EdgeType
Edge type; either etInterpolated or etNonInterpolated.
