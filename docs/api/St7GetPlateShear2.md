# St7GetPlateShear2

Returns the shear stress assigned to the specified plate surface. The shear stress is applied in the plane of the
element. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetPlateShear2(long uID, long PlateNum, long CaseNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

CaseNum

Load case number.

Plate Attributes – Get

Output Parameters
Doubles[0..1]

A 2-element array that describes the applied shear stress according to the local plate xy axis system.
