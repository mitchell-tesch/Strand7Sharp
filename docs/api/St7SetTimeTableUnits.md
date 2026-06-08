# St7SetTimeTableUnits

Sets the time units for the specified time based table.

long St7SetTimeTableUnits(long uID, long TableType, long TableID, long UnitType)

Input Parameters

uID

Strand7 model file ID.

TableType

One of ttVsTime, ttStrainTime or ttTemperatureVsTime.

TableID

Table ID.

UnitType

One of tuMilliSec, tuSec, tuMin, tuHour or tuDay.
