# St7SetLoadCaseType

Sets the type for the specified load case in a Strand7 model.

long St7SetLoadCaseType(long uID, long CaseNum, long CaseType)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Load case number.

CaseType

One of lcNoInertia, lcGravity, lcAccelerations or lcSeismic.
