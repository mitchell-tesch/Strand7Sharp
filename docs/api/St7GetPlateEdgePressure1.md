# St7GetPlateEdgePressure1

Returns the normal edge pressure assigned to the specified plate edge. The pressure is applied in the plane of the
element, perpendicular to the plate edge. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetPlateEdgePressure1(long uID, long PlateNum, long CaseNum,
long EdgeNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number
CaseNum
Load case number.
EdgeNum
Local edge number; one of 1, 2, 3 or 4.
Output Parameters
Doubles[0]
Edge pressure for the plate edge, with positive pressure directed away from the plate.
