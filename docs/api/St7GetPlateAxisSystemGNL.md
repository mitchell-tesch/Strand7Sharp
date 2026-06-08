# St7GetPlateAxisSystemGNL

Returns the plate axis system for the specified plate element based on the absolute deformed node coordinates at
the requested result case for an analysis that considers geometric nonlinearity. See Plate Local Coordinates for
additional information.

long St7GetPlateAxisSystemGNL(long uID, long PlateNum, long ResultCase,

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

Strand7 API Manual

[6..8] – A unit vector in the global XYZ system, defining the local z direction of the plate.

Applicability

Applicable to stLinearStatic, stLinearBuckling, stNonlinearStatic, stQuasiStatic, stNaturalFrequency,
stHarmonicResponse, stSpectralResponse, stLinearTransientDynamic and stNonlinearTransientDynamic, as
long as geometric nonlinearity was considered in the analysis.
