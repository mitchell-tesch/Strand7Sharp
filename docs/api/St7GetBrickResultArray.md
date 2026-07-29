# St7GetBrickResultArray

Returns the specified brick results at one of a number of sample locations in the element.

long St7GetBrickResultArray(long uID, long ResultType, long ResultSubType,
long BrickNum, long ResultCase, long SampleLocation, long* NumPoints,
long* NumColumns, double* BrickResult)
Input Parameters
uID
Strand7 model file ID.
ResultType
Brick result quantity; see Brick Results.
ResultSubType
Brick result sub-type; see Brick Results.
BrickNum
Brick number.
ResultCase
Result case number.
SampleLocation
One of spCentroid, spGaussPoints, spNodesAverageNever, spNodesAverageAll or
spNodesAverageSame.
Output Parameters
NumPoints
Number of sampling points used.
NumColumns
Number of result quantities returned at each sample location.
BrickResult[0..kMaxBrickResult-1]
[0..NumPoints*NumColumns-1] – An array containing the brick results at each sample location.
The results are returned in blocks of length NumColumns, with the start of the ith block for the ith
location at BrickResult[(i-1)*NumColumns].
See Brick Results for additional information.
