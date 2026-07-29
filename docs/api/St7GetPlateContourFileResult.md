# St7GetPlateContourFileResult

Returns a result from the most recently loaded plate contour file.

long St7GetPlateContourFileResult(long uID, long PlateNum, double* PlateResult)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number.
Output Parameters
PlateResult[0..kMaxPlateResult-1]
[0..26] – An array containing the plate result at each node and for each of the three planes. Results
are returned in three blocks of length 9 and can be accessed as
PlateResult[Surface*9 + Node - 1] where Surface is one of psPlateMidPlane, psPlateMinusZ
or psPlatePlusZ and Node is the node number index from 1 to 9.
