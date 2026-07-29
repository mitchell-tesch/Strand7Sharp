# St7GetFrequencyPeriodTableType

Returns the type of the specified Factor vs Frequency/Period table.

long St7GetFrequencyPeriodTableType(long uID, long TableID, long* FreqType)
Input Parameters
uID
Strand7 model file ID.
TableID
Table ID.
Output Parameters
FreqType
Type of frequency table; either ftPeriod or ftFrequency.
