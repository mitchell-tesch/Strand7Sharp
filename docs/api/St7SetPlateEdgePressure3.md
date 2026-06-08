# St7SetPlateEdgePressure3

Assigns a constant pressure to the specified plate edge. The pressure is defined in the global XYZ system.

long St7SetPlateEdgePressure3(long uID, long PlateNum, long CaseNum,

long EdgeNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

CaseNum

Load case number.

EdgeNum

Edge number; one of 1, 2, 3 or 4.

Doubles[0..2]

A 3-element array containing the pressure components in the global XYZ system.
