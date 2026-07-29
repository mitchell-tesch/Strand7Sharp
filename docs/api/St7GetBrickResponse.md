# St7GetBrickResponse

Returns the response variable assigned to the specified brick. Response variables are only used by the load
influence solver. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetBrickResponse(long uID, long BrickNum, long CaseNum, long* UCSId,
long* Status)
Input Parameters
uID
Strand7 model file ID.
BrickNum
Brick number.
CaseNum
Load case number.
Output Parameters
UCSId
ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.
Status[0..5]
A 6-element array describing the stress components that are flagged as response variables – lists the 11,
22, 33, 12, 23, 31 components in the 123 axis convention in the specified UCS.
