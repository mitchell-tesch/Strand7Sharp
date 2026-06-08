# St7GetResultCaseKineticEnergy

Returns the kinetic energy for the specified result case in the result file currently open.

long St7GetResultCaseKineticEnergy(long uID, long CaseNum, double* Energy)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Result case number.

Results

Output Parameters

Energy

Kinetic energy.

Applicability

Applicable to stLinearTransientDynamic and stNonlinearTransientDynamic.
