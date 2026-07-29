# St7GetPlateEdgeLengths

Returns the edge lengths of the specified plate element.

long St7GetPlateEdgeLengths(long uID, long PlateNum, long ResultCase,
double* Lengths)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number.
ResultCase
Result case number – if greater than 0, it must be a valid result case; if less than 1, it is ignored.
Output Parameters
Lengths[0..3]
Up to four edge lengths.
Usage
If a result file is open, Lengths is based on the birth coordinates of the element for the specified result case
(for a staged analysis, birth coordinates can depend on the result case). If a result file is not open, or
ResultCase is 0, Lengths is based on the initial position of the nodes.
