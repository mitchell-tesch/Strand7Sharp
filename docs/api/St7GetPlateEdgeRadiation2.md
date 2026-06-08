# St7GetPlateEdgeRadiation2

Returns the thermal radiation coefficient and ambient temperature assigned to the specified plate edge. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetPlateEdgeRadiation2(long uID, long PlateNum, long CaseNum,

long EdgeNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

CaseNum

Load case number.

EdgeNum

Local edge number.

Output Parameters
Doubles[0..1]

[0] – Radiation coefficient.

[1] – Ambient temperature.
