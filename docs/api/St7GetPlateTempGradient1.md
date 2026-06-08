# St7GetPlateTempGradient1

Returns the temperature gradient for the specified plate surface. The temperature gradient acts according to the
plate local z axis direction and is constant over the element surface. This attribute is only active for static and
dynamic structural analysis. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetPlateTempGradient1(long uID, long PlateNum, long CaseNum,

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

Temperature gradient in the local z axis direction.
