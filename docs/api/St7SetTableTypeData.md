# St7SetTableTypeData

Sets the XY data for the specified table.

long St7SetTableTypeData(long uID, long TableType, long TableID, long NumEntries,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.

TableType
One of the table types listed in Table Types.
TableID
Table ID.
NumEntries
Number of entries in table.
Doubles[0..2*NumEntries-1]
An array containing the XY data for the table. Each XY pair is stored in a block of length 2, with the start
of the ith pair at Doubles[(i-1)*2].
