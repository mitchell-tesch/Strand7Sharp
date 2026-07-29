# St7GetAccVsTimeTableUnits

Returns the units assigned to the specified acceleration vs time table.

long St7GetAccVsTimeTableUnits(long uID, long TableID, long* UnitType)
Input Parameters
uID
Strand7 model file ID.
TableID
Table ID.

Output Parameters
UnitType
Acceleration vs time units type; either atModelUnits or atGravityUnits.
