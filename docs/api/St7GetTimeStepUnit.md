# St7GetTimeStepUnit

Returns the units assigned for time stepping for the analysis.

long St7GetTimeStepUnit(long uID, long* TimeUnit)

Input Parameters

uID

Strand7 model file ID.

Output Parameters
TimeUnit

One of tuMilliSec, tuSec, tuMin, tuHour, tuDay.

Strand7 API Manual

Solver – Moving Load

These functions apply to quasi-static, transient dynamic and transient heat analysis.
