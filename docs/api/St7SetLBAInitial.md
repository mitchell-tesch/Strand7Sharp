# St7SetLBAInitial

Assigns the initial conditions file to be used for linear buckling analysis.

long St7SetLBAInitial(long uID, char* FileName, long VariableCaseNum,
long FixedCaseNum)
Input Parameters
uID
Strand7 model file ID.
FileName
Full path and name for the initial conditions file for the linear buckling solver.
VariableCaseNum
Result case number in FileName that provides the Variable Case.
FixedCaseNum
Result case number in FileName that provides the Constant Case.
