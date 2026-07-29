# St7GetResultCaseConvergence

Returns the convergence of the specified result case in the result file currently open.

long St7GetResultCaseConvergence(long uID, long CaseNum, bool* Converged)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Result case number.
Output Parameters
Converged
True if the specified result case is converged.
Applicability
Applicable to stLinearStatic, stLinearBuckling, stLoadInfluence, stNonlinearStatic, stQuasiStatic,
stNaturalFrequency, stNonlinearTransientDynamic, stSteadyHeat and stTransientHeat.
