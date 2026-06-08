# St7SetResFileFreedomCase

Assigns the freedom case associated with the result file.

long St7SetResFileFreedomCase(long uID, long CaseNum)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Freedom case number.

Applicability

Applicable to linear static, linear buckling and natural frequency custom result files. When applied to a linear
static result file, the function sets the default freedom case for result cases that have not been explicitly
assigned a freedom case using St7AssociateResFileCase.
