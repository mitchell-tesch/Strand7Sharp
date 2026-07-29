# St7GetCombinedLSACombinationState

Returns the enabled state of the specified linear load case combination for user-generated .LSA files. Only
enabled cases are generated as result cases.

long St7GetCombinedLSACombinationState(long uID, long CaseNum, bool* Enabled)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Load case combination number.
Enabled
True if the combination is enabled.
