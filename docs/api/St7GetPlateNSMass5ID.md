# St7GetPlateNSMass5ID

Returns the non-structural mass assigned to the specified plate. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetPlateNSMass5ID(long uID, long PlateNum, long CaseNum, long ID,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number.
CaseNum
Load case number.
ID
Non-structural mass ID.
Output Parameters
Doubles[0..5]
[0] – Non-structural mass for the specified plate.
[1] – Dynamic factor for the specified plate. This factor is used to scale the non-structural mass when
performing dynamic analyses.
[2..5] – A 3-element array describing the offset in the global XYZ system.
