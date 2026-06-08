# St7GetPlateUV

Returns the local plate uv coordinates corresponding to a global XYZ position. The XYZ position should be located
approximately on the surface of the element.

long St7GetPlateUV(long uID, long PlateNum, double* XYZ, double* UV)

Input Parameters

uID

Strand7 model file ID.

Strand7 API Manual

PlateNum

Plate number.

XYZ[0..2]

A 3-element array containing the global XYZ coordinates of the point.

Output Parameters
UV[0..1]

A 2-element array containing the local uv plate coordinates. See Plate Local Coordinates for additional
information.
