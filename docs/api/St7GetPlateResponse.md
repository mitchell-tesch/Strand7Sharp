# St7GetPlateResponse

Returns the response variable assigned to the specified plate. Response variables are only used by the load
influence solver. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetPlateResponse(long uID, long PlateNum, long CaseNum,
long ResponseType, long* UCSId, long* Status)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number.
CaseNum
Load case number.
ResponseType
Response variable type; either rvPlateForce or rvPlateMoment.
Output Parameters
UCSId
ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.

Status[0..5]
A 6-element array describing the force/moment components that are flagged as response variables
according to the 123 axis convention in the specified UCS – [11, 22, 33, 12, 23, 31].
