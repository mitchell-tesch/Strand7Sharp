# St7GetNumTimeStepRows

Returns the number of rows used to specify the time integration interval for the analysis. Each row may have
separate time step and integration settings.

long St7GetNumTimeStepRows(long uID, long* NumRows)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
NumRows
Number of rows.
