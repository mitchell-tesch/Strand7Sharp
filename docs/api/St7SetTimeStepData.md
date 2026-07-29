# St7SetTimeStepData

Sets the time step and integration data used for the analysis. The integration data may be specified over multiple
rows.

long St7SetTimeStepData(long uID, long Row, long NumSteps, long SaveEvery,
double TimeStep)
Input Parameters
uID
Strand7 model file ID.
Row
Integration data row.

NumSteps
Total number of time steps in row.
SaveEvery
Number of time steps between successive result cases.
TimeStep
Time step size.
