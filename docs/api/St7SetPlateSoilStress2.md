# St7SetPlateSoilStress2

Sets the in-situ soil stress for the specified plate. This attribute is only active for plates of property type soil.

long St7SetPlateSoilStress2(long uID, long PlateNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

Doubles[0..1]

A 2-element array containing the initial vertical stress and the horizontal stress ratio.
