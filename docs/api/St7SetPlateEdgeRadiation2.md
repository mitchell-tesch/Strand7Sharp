# St7SetPlateEdgeRadiation2

Sets the thermal radiation coefficient and ambient temperature for the specified plate edge.

long St7SetPlateEdgeRadiation2(long uID, long PlateNum, long CaseNum,

long EdgeNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

CaseNum

Load case number.

EdgeNum

Local edge number; one of 1, 2, 3 or 4.

Doubles[0..1]

[0] – Radiation coefficient.

[1] – Ambient temperature.
