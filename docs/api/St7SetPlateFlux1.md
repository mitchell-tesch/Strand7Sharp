# St7SetPlateFlux1

Sets the heat flux for the specified plate edge.

long St7SetPlateFlux1(long uID, long PlateNum, long CaseNum, long EdgeNum,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

CaseNum

Load case number.

EdgeNum

Local edge number; one of 1, 2, 3 or 4.

Doubles[0]

Heat flux through the plate edge.
