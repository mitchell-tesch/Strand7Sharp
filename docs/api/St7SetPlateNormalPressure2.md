# St7SetPlateNormalPressure2

Assigns constant normal pressures to the outer +z and -z surfaces of the specified plate. The pressure is specified
as a positive pressure on each face, directed inwards towards the mid-plane of the plate.

long St7SetPlateNormalPressure2(long uID, long PlateNum, long CaseNum,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Plate Attributes – Set

PlateNum

Plate number.

CaseNum

Load case number.

Doubles[0..1]

[0] – Normal face pressure over the -z surface of the plate.

[1] – Normal face pressure over the +z surface of the plate.

Usage

Positive pressure is directed from the relevant surface onto the plate.
