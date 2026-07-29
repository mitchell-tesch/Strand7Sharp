# St7GetHRARange

Returns the frequency range assigned for harmonic response analysis.

long St7GetHRARange(long uID, long* NumSteps, double* F1, double* F2,
bool* AutoInsert)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
NumSteps
Number of steps in the range.
F1
Starting frequency (Hz).
F2
Finishing frequency (Hz).

AutoInsert
True if additional steps are automatically inserted within the range. This feature is used to ensure that
peaks in the frequency response are adequately captured.
