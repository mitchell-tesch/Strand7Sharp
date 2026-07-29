# St7GetTableInfoByIndex

Returns the name and ID number of the specified table. The maximum table index is returned by the
St7GetNumTables function.

long St7GetTableInfoByIndex(long uID, long TableType, long Index, long* TableID,
char* TableName, long MaxStringLen)
Input Parameters
uID
Strand7 model file ID.
TableType
One of the table types listed in Table Types.
Index
Table index.
MaxStringLen
The maximum number of characters allocated for TableName.
Output Parameters
TableID
Table ID.

TableName
Name of the table.
