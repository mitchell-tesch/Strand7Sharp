# St7GetGeometrySurfaceType

Returns the type of the specified surface.

long St7GetGeometrySurfaceType(long uID, long SurfaceNum, long* SurfaceType)
Input Parameters
uID
Strand7 model file ID.
SurfaceNum
Surface number.
Output Parameters
SurfaceType
One of suPlane, suSphere, suTorus, suCone, suBSpline, suRotSur, suPipeSur, suSumSur, suTabCyl,
suRuleSur, suCubicSpline or suNull.
