# St7SetPlateFaceConvection2

Sets the thermal convection coefficient and ambient temperature for the specified plate surface. This attribute is
only used when performing heat transfer analysis.

long St7SetPlateFaceConvection2(long uID, long PlateNum, long CaseNum,

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

Doubles[0..1]

[0] – Convection coefficient.

[1] – Ambient temperature.
