# St7GetSolverLoadCaseTemperatureDependence

Returns the load case assigned to specify the temperature dependence for the analysis.

long St7GetSolverLoadCaseTemperatureDependence(long uID, long* CaseNum)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
CaseNum
Load case number or 0 for none.
Applicability
Applicable to linear static, load influence, natural frequency and linear transient dynamic analysis.
