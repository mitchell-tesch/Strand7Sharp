# St7GetGeometryEdgeType

Returns the type assigned to the specified geometry edge. This determines how its attributes are inherited by
elements created by the automesher.

long St7GetGeometryEdgeType(long uID, long EdgeNum, long* EdgeType)

Input Parameters

uID

Strand7 model file ID.

EdgeNum

Edge number.

Output Parameters
EdgeType

Edge type; either etInterpolated or etNonInterpolated.
