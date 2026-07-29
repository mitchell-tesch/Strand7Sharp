# St7GetFrequencyPeriodTableUnits

Returns the units for the specified Factor vs Frequency/Period table.

long St7GetFrequencyPeriodTableUnits(long uID, long TableID, long* UnitType)
Input Parameters
uID
Strand7 model file ID.
TableID
Table ID.
Output Parameters
UnitType
One of fuNone, fuDispResponse, fuVelResponse, fuAccelResponse, fuDispPSD, fuVelPSD, fuAccelPSD,
fuAccelResponseG or fuAccelPSDG.
