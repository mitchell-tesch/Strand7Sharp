# St7GetModeDampingRatio

Returns the modal damping ratio assigned for the specified mode in the modal superposition file.

long St7GetModeDampingRatio(long uID, long ModeNum, double* Ratio)
Input Parameters
uID
Strand7 model file ID.

ModeNum
Mode number.
Output Parameters
Ratio
Modal damping ratio.
Applicability
Applicable to harmonic response, spectral response and linear transient dynamic analysis with mode
superposition.
