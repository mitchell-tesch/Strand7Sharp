# St7GetLBAInitial

Returns the initial conditions file assigned for linear buckling analysis.

long St7GetLBAInitial(long uID, char* FileName, long* VariableCaseNum,
long* FixedCaseNum, long MaxStringLen)
Input Parameters
uID
Strand7 model file ID.
MaxStringLen
Maximum number of characters allocated for FileName.
Output Parameters
FileName
Full path and name for the initial conditions file used by the linear buckling solver.
VariableCaseNum
Result case number in FileName that provides the Variable Case.
FixedCaseNum
Result case number in FileName that provides the Constant Case.
