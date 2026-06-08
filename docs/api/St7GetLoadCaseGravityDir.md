# St7GetLoadCaseGravityDir

Returns the direction of the gravity vector assigned to the specified load case.

long St7GetLoadCaseGravityDir(long uID, long CaseNum, long* GravDir)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Load case number.

Output Parameters

GravDir

Gravity direction specified in the global XYZ system; one of 1, 2 or 3.
