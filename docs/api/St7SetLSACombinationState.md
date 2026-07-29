# St7SetLSACombinationState

Sets the enabled state of the specified linear load case combination for solver-generated .LSA files. Only enabled
cases are generated as result cases.

long St7SetLSACombinationState(long uID, long CaseNum, bool Enabled)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Load case combination number.
Enabled
True to enable the combination.
