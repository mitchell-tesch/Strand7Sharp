# St7GetNumIterations

Returns the total number of iterations performed by the solver for the result file currently open.

long St7GetNumIterations(long uID, long* NumIterations)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
NumIterations
Number of iterations.
Applicability
Applicable to stLinearBuckling, stNaturalFrequency, stNonlinearStatic, stQuasiStatic,
stNonlinearTransientDynamic, stSteadyHeat and stTransientHeat.
Usage
The number returned is the number of solver iterations performed up to the last saved result case in the
result file. If additional iterations are performed after the last saved result case, those iterations are not
counted.
If the solver was launched as a restart, the number of iterations performed in the restart is returned, not the
cumulative number of iterations.
