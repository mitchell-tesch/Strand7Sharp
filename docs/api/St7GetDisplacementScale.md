# St7GetDisplacementScale

Returns the Displacement Scale used to draw the deformed model when an associated model result file is open.

long St7GetDisplacementScale(long uID, double* DispScale, long* ScaleType)

Input Parameters

uID

Strand7 model file ID.

Output Parameters
DispScale

The scaling factor or percentage applied.

ScaleType

The manner of scaling used; either dsPercent or dsAbsolute.
