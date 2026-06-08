# St7GetWindowColours

Returns the background colour(s) of the model window.

long St7GetWindowColours(long uID, long WindowMode, long* SolidColour,

long* GradientColour)

Input Parameters

uID

Strand7 model file ID.

WindowMode

Either wmPreProcessing or wmPostProcessing.

Output Parameters
SolidColour

Solid background colour or upper colour for gradient backgrounds.  See also RGB Colours.

GradientColour

Lower colour for gradient backgrounds.  See also RGB Colours.
