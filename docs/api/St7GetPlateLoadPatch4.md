# St7GetPlateLoadPatch4

Returns the load patch type assigned to the specified plate. This attribute is only active for plates of property type
load patch.

long St7GetPlateLoadPatch4(long uID, long PlateNum, long* PatchType,
long* EdgeBits, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number.
Output Parameters
PatchType
One of ptAuto4, ptAuto3, ptAuto2, ptAuto1, ptAngleSplit or ptManual.
EdgeBits
A 32-bit value in which the four least significant bits specify the selection of up to four edges. See Load
Patch Types for additional information.
Doubles[0..3]
Edge weights. See Load Patch Types for additional information.
