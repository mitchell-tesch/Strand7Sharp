# St7GetPlatePreLoad3

Returns the pre-load conditions for the specified plate. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetPlatePreLoad3(long uID, long PlateNum, long CaseNum, long* LoadType,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

CaseNum

Load case number.

Output Parameters
LoadType

Pre-load type; either plPlatePreStrain or plPlatePreStress.

Doubles[0..2]

A 3-element array describing the pre-load condition. Doubles[i-1] describes the pre-load in the ith
local axis direction.
