# St7GenerateHRATimeHistory

Generates the time history response for the specified model based on a harmonic response analysis. An
associated harmonic response result file must currently be open.

long St7GenerateHRATimeHistory(long uID, double StartTime, double EndTime,

long NumSteps, long* WarningCode)

Input Parameters

uID

Strand7 model file ID.

StartTime

Start time for the time history integration.

EndTime

End time for the time history integration.

NumSteps

Number of steps used for the time history integration.

Output Parameters
WarningCode

Either wcHarmonicCombineNoWarning, if the operation was successful, or
wcHarmonicCombineInvalidLSA, if the time history was generated but the specified linear static file was
invalid.
