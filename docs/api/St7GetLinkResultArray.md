# St7GetLinkResultArray

Returns the specified link result quantity at each node in the link.

long St7GetLinkResultArray(long uID, long ResultType, long UCSId, long LinkNum,
long ResultCase, long* NumPoints, long* NumColumns, double* LinkResult,
long ArrayDim)
Input Parameters
uID
Strand7 model file ID.
ResultType
One of rtLinkNodeDisp, rtLinkNodeBirthDisp, rtLinkNodeReact, or rtLinkNodeFlux.
UCSId
ID number of a UCS frame into which vector results are transformed. UCSId = 1 refers to the global XYZ
system.
LinkNum
Link number.
ResultCase
Result case number.

ArrayDim
Size of the array LinkResult.
Output Parameters
NumPoints
Number of nodes in the link.
NumColumns
Number of result quantities returned at each node.
LinkResult[0..ArrayDim-1]
[0..NumPoints*NumColumns-1] – an array containing the link results at each node.
The results are returned in blocks of length NumColumns with the start of the ith block for the ith node at
LinkResult[(i-1)*NumColumns].
