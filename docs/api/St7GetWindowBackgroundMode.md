# St7GetWindowBackgroundMode

Returns the background mode of the model window.

long St7GetWindowBackgroundMode(long uID, long WindowMode, long* BackgroundMode)
Input Parameters
uID
Strand7 model file ID.
WindowMode
Either wmPreProcessing or wmPostProcessing.
Output Parameters
BackgroundMode
One of bgSolid, bgImage, bgGradient or bgImageGradient.
