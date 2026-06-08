# St7SetPlateGlobalPressure3S

Assigns a constant face pressure to the specified plate surface.  The pressure is defined in the global XYZ system.

long St7SetPlateGlobalPressure3S(long uID, long PlateNum, long Surface,

long ProjectFlag, long CaseNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

Surface

Plate surface; either psPlateMinusZ or psPlatePlusZ.

ProjectFlag

One of ppNone, ppProjResultant or ppProjComponents.

CaseNum

Load case number.

Doubles[0..2]

A 3-element array containing the pressure components in the global XYZ system.
