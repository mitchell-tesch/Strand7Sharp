# St7GetTableTypeData

Returns the XY data for the specified table.

long St7GetTableTypeData(long uID, long TableType, long TableID, long MaxRows,
long* NumRows, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
TableType
One of the table types listed in Table Types.
TableID
Table ID.
MaxRows
Maximum number of rows allocated for Doubles.
Output Parameters
NumRows
Number of rows used.
Doubles[0..2*MaxRows-1]
An array containing the XY data for the table. Each XY pair is stored in a block of length 2, with the start
of the ith pair at Doubles[(i-1)*2].
