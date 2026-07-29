# St7SetDisplacementScale

Sets the Displacement Scale used to draw the deformed model, when an associated model result file is open.

long St7SetDisplacementScale(long uID, double DispScale, long ScaleType)
Input Parameters
uID
Strand7 model file ID.
DispScale
The scaling factor or percentage to be applied.
ScaleType
The manner of scaling to be used; either dsPercent or dsAbsolute.
