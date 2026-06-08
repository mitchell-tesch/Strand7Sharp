# St7GetNodeTemperatureType1

Returns the temperature type assigned at the specified node. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetNodeTemperatureType1(long uID, long NodeNum, long CaseNum,

long* TType)

Input Parameters

uID

Strand7 model file ID.

NodeNum

Node number.

CaseNum

Load case number.

Output Parameters

TType

One of ntReferenceTemperature, ntFixedTemperature, ntInitialTemperature or ntTableTemperature.
Use St7GetNodeTemperatureTable to return the table.

Strand7 API Manual
