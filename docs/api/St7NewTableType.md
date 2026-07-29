# St7NewTableType

Creates a new table in the specified model.

long St7NewTableType(long uID, long TableType, long TableID, long NumEntries,
char* TableName, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
TableType
One of the table types listed in Table Types.
TableID
Table ID.
NumEntries
Number of rows (or XY data pairs) in the table.
TableName
Name of the table.
Doubles[0..2*NumEntries-1]
An array containing the XY data for the table. Each XY pair is stored in a block of length 2, with the start
of the ith pair at Doubles[(i-1)*2].
