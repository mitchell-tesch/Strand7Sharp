# St7GetPlateAxisSystemBirth

Returns the plate axis system for the specified plate element based on the node coordinates at the element’s
birth stage. The birth stage is determined from the requested result case. See Plate Local Coordinates for
additional information.

long St7GetPlateAxisSystemBirth(long uID, long PlateNum, long ResultCase,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number.
ResultCase
Result case number.
Output Parameters
Doubles[0..8]
[0..2] – A unit vector in the global XYZ system, defining the local x direction of the plate.
[3..5] – A unit vector in the global XYZ system, defining the local y direction of the plate.
[6..8] – A unit vector in the global XYZ system, defining the local z direction of the plate.
Applicability
Applicable to stLinearStatic, stLinearBuckling, stNonlinearStatic, stQuasiStatic, stNaturalFrequency,
stHarmonicResponse, stSpectralResponse, stLinearTransientDynamic and stNonlinearTransientDynamic.
