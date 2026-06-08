# St7GetPlateFlux1

Returns the heat flux assigned to the specified plate edge. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetPlateFlux1(long uID, long PlateNum, long CaseNum, long EdgeNum,

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

Output Parameters
Doubles[0]

Heat flux through the plate edge.
