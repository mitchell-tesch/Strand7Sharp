# St7GetBrickFaceAxisSystemGNL

Returns the brick face axis system for the specified brick face based on the absolute deformed node coordinates
at the requested result case for an analysis that considers geometric nonlinearity. See Brick Local Coordinates for
additional information.

long St7GetBrickFaceAxisSystemGNL(long uID, long BrickNum, long FaceNum, long

ResultCase, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BrickNum

Brick number.

FaceNum

Local face number. See Brick Local Coordinates for additional information.

ResultCase

Result case number.

Output Parameters
Doubles[0..8]

[0..2] – A unit vector in the global XYZ system, defining the local x direction of the face.

[3..5] – A unit vector in the global XYZ system, defining the local y direction of the face.

[6..8] – A unit vector in the global XYZ system, defining the local z direction of the face; note that this
is directed out of the median plane of the face.

Strand7 API Manual

Applicability

Applicable to stLinearStatic, stLinearBuckling, stNonlinearStatic, stQuasiStatic, stNaturalFrequency,
stHarmonicResponse, stSpectralResponse, stLinearTransientDynamic and stNonlinearTransientDynamic, as
long as geometric nonlinearity was considered in the analysis.
