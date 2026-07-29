# St7GetPlatePreCurvature2

Returns the pre-curvature conditions for the specified plate. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetPlatePreCurvature2(long uID, long PlateNum, long CaseNum,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number.
CaseNum
Load case number.
Output Parameters
Doubles[0..1]
A 2-element array describing the pre-curvature in the local x and y directions, respectively.
