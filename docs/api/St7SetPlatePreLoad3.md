# St7SetPlatePreLoad3

Sets the pre-load conditions for the specified plate.

long St7SetPlatePreLoad3(long uID, long PlateNum, long CaseNum, long LoadType,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

CaseNum

Load case number.

LoadType

Pre-load type; either plPlatePreStrain or plPlatePreStress.

Doubles[0..2]

A 3-element array describing the pre-load condition. Doubles[i-1] describes the pre-load in the ith
local axis direction.
