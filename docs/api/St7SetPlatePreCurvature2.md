# St7SetPlatePreCurvature2

Sets the pre-curvature conditions for the specified plate.

long St7SetPlatePreCurvature2(long uID, long PlateNum, long CaseNum,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number.
CaseNum
Load case number.
Doubles[0..1]
A 2-element array describing the pre-curvature in the local x and y directions, respectively.
