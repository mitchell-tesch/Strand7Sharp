# St7GetResultPropertyState

Returns the enabled state of the specified property results for the analysis. Only element results corresponding to
enabled properties are written to the result file.

long St7GetResultPropertyState(long uID, long Entity, long PropNum,
bool* Enabled)
Input Parameters
uID
Strand7 model file ID.
Entity
One of ptBEAMPROP, ptPLATEPROP or ptBRICKPROP.
PropNum
Property number.
Output Parameters
Enabled
True if the specified property results are enabled.
