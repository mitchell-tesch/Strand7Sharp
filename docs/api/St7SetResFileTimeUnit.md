# St7SetResFileTimeUnit

Sets the time units displayed in the specified custom result file. Note that this setting does not affect the time
input to St7SetResFileTime, which is always in seconds.

long St7SetResFileTimeUnit(long uID, long TimeUnit)

Input Parameters

uID

Strand7 model file ID.

TimeUnit

One of tuMilliSec, tuSec, tuMin, tuHour or tuDay.

Strand7 API Manual
