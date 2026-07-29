# St7NewResFile

Creates a new custom result file.

long St7NewResFile(long uID, char* FileName, long ResultType)
Input Parameters
uID
Strand7 model file ID.
FileName
Full path and name for the new custom result file.
ResultType
One of stLinearStatic, stLinearBuckling, stNonlinearStatic, stQuasiStatic, stNaturalFrequency,
stLinearTransientDynamic, stNonlinearTransientDynamic, stSteadyHeat, stTransientHeat.
