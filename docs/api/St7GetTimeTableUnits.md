# St7GetTimeTableUnits

Returns the time units assigned to the specified time based table.

long St7GetTimeTableUnits(long uID, long TableType, long TableID, long* UnitType)

Input Parameters

uID

Strand7 model file ID.

Strand7 API Manual

TableType

One of ttVsTime, ttStrainTime or ttTemperatureVsTime.

TableID

Table ID.

Output Parameters
UnitType

One of tuMilliSec, tuSec, tuMin, tuHour or tuDay.
