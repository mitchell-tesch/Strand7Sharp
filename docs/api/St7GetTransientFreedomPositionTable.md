# St7GetTransientFreedomPositionTable

Returns the Factor vs Position table that factors restraint conditions on the basis of a selected spatial Degree of
Freedom (DoF) for the specified freedom case for quasi-static and nonlinear transient dynamic analysis.

long St7GetTransientFreedomPositionTable(long uID, long CaseNum, long* TableID,
long* UCSId, long* Axis)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Freedom case number.
Output Parameters
TableID
ID number for the Factor vs Position table, or 0 for none.
UCSId
ID number of the UCS supplying a spatial DoF to factor. UCSId = 1 refers to the global XYZ system.
Axis
The UCS DoF used, 1, 2 or 3.
