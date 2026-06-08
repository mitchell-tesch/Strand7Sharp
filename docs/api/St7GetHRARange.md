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

Starting frequency (Hz).

Finishing frequency (Hz).

F1

F2

Strand7 API Manual

AutoInsert

True if additional steps are automatically inserted within the range. This feature is used to ensure that
peaks in the frequency response are adequately captured.
