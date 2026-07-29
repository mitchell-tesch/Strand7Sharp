# St7GetFactorsEnvelopeSetData

Returns the settings assigned to the specified set in a factors envelope for the currently open solution.

long St7GetFactorsEnvelopeSetData(long uID, long Pos, long* SetType,
char* SetName, char* SetGroup, long MaxStringLen)
Input Parameters
uID
Strand7 model file ID.
Pos
Set position.
MaxStringLen
Maximum number of characters allocated for SetName.
Output Parameters
SetType
Type of set; either stExclusiveOR or stExclusiveAND.
SetName
Name of the set.
SetGroup
Group identifier for set.

Result File Combination
