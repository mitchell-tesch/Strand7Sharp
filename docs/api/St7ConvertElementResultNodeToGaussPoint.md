# St7ConvertElementResultNodeToGaussPoint

Converts element nodal results to Gauss point results via interpolation. It is important to specify the un-averaged
nodal quantities in order to capture the true element Gauss point values.

long St7ConvertElementResultNodeToGaussPoint(long Entity, long NumNodes,
long NumColumns, double* NodeDoubles, long* NumGauss, double* GaussDoubles)
Input Parameters
Entity
Either tyPLATE or tyBRICK.
NumNodes
Number of nodes in the element.
NumColumns
Number of result quantities contained in the NodeDoubles array.
NodeDoubles[0..NumNodes*NumColumns-1]
An array containing the nodal result quantities, arranged in NumNodes blocks of length NumColumns.
The start of the ith block, relating to the ith node in the element’s definition, is at
NodeDoubles[(i-1)*NumColumns].
Output Parameters
NumGauss
Number of result Gauss points for the element; a maximum of 9 for tyPLATE, or 27 for tyBRICK.
GaussDoubles[0..NumGauss*NumColumns-1]
An array containing the interpolated Gauss point result quantities, arranged in NumGauss blocks of
length NumColumns. The start of the ith block, relating to the ith Gauss point in the element’s definition,
is at GaussDoubles[(i-1)*NumColumns].
