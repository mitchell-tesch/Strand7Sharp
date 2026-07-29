# St7GetPlateEdgePressure3

Returns the global edge pressure assigned to the specified plate edge. The pressure is constant and is defined in
the global XYZ system. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetPlateEdgePressure3(long uID, long PlateNum, long CaseNum,
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
Doubles[0..2]
A 3-element array containing the pressure components in the global XYZ system.
