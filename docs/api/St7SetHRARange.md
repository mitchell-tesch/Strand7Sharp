# St7SetHRARange

Assigns the frequency range for harmonic response analysis.

long St7SetHRARange(long uID, long NumSteps, double F1, double F2,

bool AutoInsert)

Input Parameters

uID

Strand7 model file ID.

NumSteps

Number of steps in the range.

F1

F2

Starting frequency (Hz).

Finishing frequency (Hz).

AutoInsert

True to automatically insert additional steps within the range. This feature is used to ensure that peaks
in the frequency response are adequately captured.
