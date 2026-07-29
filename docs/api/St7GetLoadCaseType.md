# St7GetLoadCaseType

Returns the type for the specified load case in a Strand7 model.

long St7GetLoadCaseType(long uID, long CaseNum, long* CaseType)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Load case number.

Output Parameters
CaseType
One of lcNoInertia, lcGravity, lcAccelerations or lcSeismic.
