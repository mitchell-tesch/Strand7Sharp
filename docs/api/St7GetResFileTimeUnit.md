# St7GetResFileTimeUnit

Returns the time units displayed in the specified custom result file. Note that this setting does not affect the time
output by St7GetResFileTime, which is always in seconds.

long St7GetResFileTimeUnit(long uID, long* TimeUnit)

Input Parameters

uID

Strand7 model file ID.

Output Parameters
TimeUnit

One of tuMilliSec, tuSec, tuMin, tuHour or tuDay.
