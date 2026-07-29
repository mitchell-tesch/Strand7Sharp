# St7SetFreedomCaseType

Sets the type for the specified freedom case in a Strand7 model.

long St7SetFreedomCaseType(long uID, long CaseNum, long CaseType)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Freedom case number.
CaseType
One of fcNormalFreedom, fcFreeBodyInertiaRelief, fcSingleSymmetryInertiaXY,
fcSingleSymmetryInertiaYZ, fcSingleSymmetryInertiaZX, fcDoubleSymmetryInertiaX,
fcDoubleSymmetryInertiaY or fcDoubleSymmetryInertiaZ.
