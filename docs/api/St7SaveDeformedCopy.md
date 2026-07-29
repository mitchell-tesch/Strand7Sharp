# St7SaveDeformedCopy

Saves a copy of a Strand7 model to a new file with the current node displacements added to the original node
coordinates to produce a new model with a deformed shape. The model results file must be open prior to calling
this function.

long St7SaveDeformedCopy(long uID, char* FileName, long ResultCase,
double DispScale, long ScaleType)
Input Parameters
uID
Strand7 model file ID.
FileName
Full path and filename for the new Strand7 model.
ResultCase
The result case from which the deformed shape is taken.
DispScale
The displacement scale of the deformed shape.
ScaleType
The type of scale to apply; either dsPercent or dsAbsolute.
Applicability
Applicable to stLinearStatic, stLinearBuckling, stLoadInfluence, stNonlinearStatic, stQuasiStatic,
stNaturalFrequency, stHarmonicResponse, stSpectralResponse, stLinearTransientDynamic and
stNonlinearTransientDynamic.
