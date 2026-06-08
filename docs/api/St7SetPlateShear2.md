# St7SetPlateShear2

Assigns a face shear stress to the specified plate. The shear stress is applied in the plane of the element.

Strand7 API Manual

long St7SetPlateShear2(long uID, long PlateNum, long CaseNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

CaseNum

Load case number.

Doubles[0..1]

A 2-element array that describes the applied shear stress according to the local plate xy axis system.
