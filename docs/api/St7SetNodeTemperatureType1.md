# St7SetNodeTemperatureType1

Sets the type of temperature at the specified node.

long St7SetNodeTemperatureType1(long uID, long NodeNum, long CaseNum, long TType)
Input Parameters
uID
Strand7 model file ID.
NodeNum
Node number.
CaseNum
Load case number.
TType
The type of temperature attribute applied at the specified node: ntReferenceTemperature,
ntFixedTemperature, ntInitialTemperature or ntTableTemperature. If required, use
St7SetNodeTemperatureTable to set the table.
