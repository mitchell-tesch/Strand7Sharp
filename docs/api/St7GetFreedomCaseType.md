# St7GetFreedomCaseType

Returns the type of the specified freedom case with a Strand7 model.

Strand7 API Manual

long St7GetFreedomCaseType(long uID, long CaseNum, long* CaseType)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Freedom case number.

Output Parameters
CaseType

One of fcNormalFreedom, fcFreeBodyInertiaRelief, fcSingleSymmetryInertiaXY,
fcSingleSymmetryInertiaYZ, fcSingleSymmetryInertiaZX, fcDoubleSymmetryInertiaX,
fcDoubleSymmetryInertiaY or fcDoubleSymmetryInertiaZ.
