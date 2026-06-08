# St7GetPlateGlobalPressure3S

Returns the pressure applied to the specified plate surface.  The pressure is constant and is defined in the global
XYZ system. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetPlateGlobalPressure3S(long uID, long PlateNum, long Surface,

long CaseNum, long* ProjectFlag, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

Surface

Plate surface; either psPlateMinusZ or psPlatePlusZ.

CaseNum

Load case number.

Output Parameters
ProjectFlag

One of ppNone, ppProjResultant or ppProjComponents.

Doubles[0..2]

A 3-element array containing the pressure components in the global XYZ system.
