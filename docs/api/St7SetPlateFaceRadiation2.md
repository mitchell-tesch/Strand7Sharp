# St7SetPlateFaceRadiation2

Sets the thermal radiation coefficient and ambient temperature for the specified plate surface.

long St7SetPlateFaceRadiation2(long uID, long PlateNum, long CaseNum,
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
[0] – Radiation coefficient.
[1] – Ambient temperature.
