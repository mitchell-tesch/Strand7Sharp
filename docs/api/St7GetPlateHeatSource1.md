# St7GetPlateHeatSource1

Returns the heat source assigned to the specified plate. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetPlateHeatSource1(long uID, long PlateNum, long CaseNum,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.

PlateNum
Plate number.
CaseNum
Load case number.
Output Parameters
Doubles[0]
Heat source.
