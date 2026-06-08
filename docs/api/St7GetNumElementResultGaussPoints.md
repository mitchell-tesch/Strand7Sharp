# St7GetNumElementResultGaussPoints

Returns the number of Gauss points used to store result quantities for the specified entity type.

Helper Functions

long St7GetNumElementResultGaussPoints(long Entity, long NumNodes,

long* NumGauss)

Input Parameters
Entity

Either tyPLATE or tyBRICK.

NumNodes

Number of nodes for the element type.

Output Parameters
NumGauss

Number of result Gauss points.
