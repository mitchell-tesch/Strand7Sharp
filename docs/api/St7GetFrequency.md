# St7GetFrequency

Returns the frequency for the specified result case in the result file currently open.

Strand7 API Manual

long St7GetFrequency(long uID, long Mode, double* Freq)

Input Parameters

uID

Strand7 model file ID.

Mode

Result case/mode number.

Output Parameters

Freq

Mode frequency (Hz).

Applicability

Applicable to stNaturalFrequency and stHarmonicResponse.
