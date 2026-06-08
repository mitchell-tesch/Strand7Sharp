# St7GetPlateSoilRatio2

Returns the in-situ soil ratios assigned to the specified plate. This attribute is only active for plates of property
type soil.

long St7GetPlateSoilRatio2(long uID, long PlateNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

Output Parameters
Doubles[0..1]

A 2-element array containing the overconsolidation ratio and the initial void ratio.
