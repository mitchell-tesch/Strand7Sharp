# St7SetHRACombinationFactorLSA

Sets the result factor for a linear static result case in harmonic time results.

long St7SetHRACombinationFactorLSA(long uID, long LoadCaseNum,
long FreedomCaseNum, double Factor)
Input Parameters
uID
Strand7 model file ID.
LoadCaseNum
For solver generated linear static result files, the load case number. For Result File Combination
generated linear static result files, the result case number.
FreedomCaseNum
For solver generated linear static result files, the freedom case number. For Result File Combination
generated linear static result files use 0.
Factor
Factor value.
