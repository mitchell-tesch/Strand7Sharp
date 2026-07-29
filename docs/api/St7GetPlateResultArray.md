# St7GetPlateResultArray

Returns the specified plate results at a series of sample locations on the element.

long St7GetPlateResultArray(long uID, long ResultType, long ResultSubType,
long PlateNum, long ResultCase, long SampleLocation, long Surface,
long Layer, long* NumPoints, long* NumColumns, double* PlateResult)
Input Parameters
uID
Strand7 model file ID.
ResultType
Plate result quantity; see Plate Results.

ResultSubType
Plate result sub-type; see Plate Results.
PlateNum
Plate number.
ResultCase
Result case number.
SampleLocation
One of spCentroid, spGaussPoints, spNodesAverageNever, spNodesAverageAll or
spNodesAverageSame.
Surface
One of psPlateMidPlane, psPlateMinusZ or psPlatePlusZ.
Layer
Relevant to reinforced concrete or composite results; see Plate Results.
Output Parameters
NumPoints
Number of sample locations used.
NumColumns
Number of result quantities returned at each sample location.
PlateResult[0..kMaxPlateResult-1]
[0..NumPoints*NumColumns-1] – An array containing the plate results at each sample location.
The results are returned in blocks of length NumColumns, with the start of the ith block for the ith
location at PlateResult[(i-1)*NumColumns].
See Plate Results for additional information.
