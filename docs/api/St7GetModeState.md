# St7GetModeState

Returns the enabled state of the specified mode in the modal superposition file for harmonic response, spectral
response and linear transient dynamic analysis with mode superposition.

long St7GetModeState(long uID, long ModeNum, bool* Enabled)
Input Parameters
uID
Strand7 model file ID.
ModeNum
Mode number.
Output Parameters
Enabled
True if the mode is enabled.
