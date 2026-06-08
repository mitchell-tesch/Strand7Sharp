# St7GetPlatePointMoment6

Returns the point moment assigned to the specified plate. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetPlatePointMoment6(long uID, long PlateNum, long CaseNum,

long Position, long ID, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

CaseNum

Load case number.

Position

Position identifier; either axUCS or axLocal.

Plate Attributes – Get

ID

Local ID number for the point moment.

Output Parameters
Doubles[0..5]

[0..2] – Components of the applied moment in the global XYZ system.

Where Position is axUCS:
[3..5] – The position of the point moment in global XYZ coordinates.

Where Position is axLocal:
[3..4] – The uv position of the point moment in the local element coordinate system.
