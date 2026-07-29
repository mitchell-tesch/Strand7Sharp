# St7GetSRALoadCaseTable

Returns the table associated with the specified Spectral Response analysis Load Excitation case.

long St7GetSRALoadCaseTable(long uID, long SRACase, long CaseNum, long* TableID)
Input Parameters
uID
Strand7 model file ID.
SRACase
Spectral Response load excitation case number.
CaseNum
Load case number.
Output Parameters
TableID
Table ID number, or 0 for none.
