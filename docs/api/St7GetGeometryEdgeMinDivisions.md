# St7GetGeometryEdgeMinDivisions

Returns the minimum number of elements to be created by the automesher along the specified geometry edge.

long St7GetGeometryEdgeMinDivisions(long uID, long EdgeNum, long* Divisions)

Input Parameters

uID

Strand7 model file ID.

EdgeNum

Edge number.

Output Parameters
Divisions

Minimum number of elements along the geometry edge.
