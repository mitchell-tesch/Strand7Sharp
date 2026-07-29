# St7ConvertTimeTableUnits

Converts the time units for the specified time based table.

long St7ConvertTimeTableUnits(long uID, long TableType, long TableID,
long UnitType)
Input Parameters
uID
Strand7 model file ID.
TableType
Either ttVsTime or ttStrainTime.
TableID
Table ID.
UnitType
One of tuMilliSec, tuSec, tuMin, tuHour or tuDay.
