# St7SetLoadCaseMassOption

Sets the mass options for the specified load case in a Strand7 model.

long St7SetLoadCaseMassOption(long uID, long CaseNum, bool SMass, bool NSMass)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Load case number.

SMass

True to apply global accelerations to structural mass.

NSMass

True to apply global accelerations to non-structural mass.
