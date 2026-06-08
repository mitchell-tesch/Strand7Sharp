# St7GetPlateNormalPressure2

Returns the normal pressures applied to the outer +z and -z surfaces of the specified plate. The pressure is
constant and is specified as a positive pressure on each face, directed inwards towards the mid-plane of the plate.
See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetPlateNormalPressure2(long uID, long PlateNum, long CaseNum,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

CaseNum

Load case number.

Output Parameters
Doubles[0..1]

[0] – Normal face pressure over the -z surface of the plate.

Strand7 API Manual

[1] – Normal face pressure over the +z surface of the plate.

Positive pressure is directed from the relevant surface into the plate.
