# St7GetLoadCaseMassOption

Returns the mass options for the specified load case in a Strand7 model.

long St7GetLoadCaseMassOption(long uID, long CaseNum, bool* SMass, bool* NSMass)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Load case number.

Output Parameters
SMass
If True, global accelerations are applied to structural mass.
NSMass
If True, global accelerations are applied to non-structural mass.
