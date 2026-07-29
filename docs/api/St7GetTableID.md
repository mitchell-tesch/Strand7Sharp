# St7GetTableID

Returns the ID number for a table specified by name. Where multiple names exist, the table ID with the lowest
table index is returned.

long St7GetTableID(long uID, char* TableName, long TableType, long* TableID)
Input Parameters
uID
Strand7 model file ID.
TableName
Name of the table.
TableType
One of the table types listed in Table Types.
Output Parameters
TableID
Table ID.
