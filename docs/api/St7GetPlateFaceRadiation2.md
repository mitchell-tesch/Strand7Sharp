# St7GetPlateFaceRadiation2

Returns the thermal radiation coefficient and ambient temperature assigned to the specified plate. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetPlateFaceRadiation2(long uID, long PlateNum, long CaseNum,

long Surface, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

CaseNum

Load case number.

Surface

Local plate surface; either psPlateMinusZ or psPlatePlusZ.

Plate Attributes – Get

Output Parameters
Doubles[0..1]

[0] – Radiation coefficient.

[1] – Ambient temperature.
