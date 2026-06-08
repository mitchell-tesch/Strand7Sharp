# St7GetPlatePointForce6

Returns the point force assigned to the specified plate. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

Strand7 API Manual

long St7GetPlatePointForce6(long uID, long PlateNum, long CaseNum, long Position,

long ID, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

CaseNum

Load case number.

Position

Position identifier; either axUCS or axLocal.

ID

Local ID number for the point force.

Output Parameters
Doubles[0..5]

[0..2] – Components of the applied force in the global XYZ system.

Where Position is axUCS,
[3..5] – The position of the point force specified in global XYZ coordinates.

Where Position is axLocal,
[3..4] – The uv position of the point force in the local element coordinate system.
