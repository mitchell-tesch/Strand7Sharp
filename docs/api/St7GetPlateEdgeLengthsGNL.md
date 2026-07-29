# St7GetPlateEdgeLengthsGNL

Returns the edge lengths of the specified plate element for geometrically nonlinear results.

long St7GetPlateEdgeLengthsGNL(long uID, long PlateNum, long ResultCase,
double* Lengths)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number.
ResultCase
Result case number.
Output Parameters
Lengths[0..3]
Up to four edge lengths.
Usage
A result file that includes geometric nonlinearity must be open when calling this function. The lengths are
calculated based on the element deformation at an absolute displacement scale of 1 for the specified result
case.
