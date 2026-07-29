# St7GetSolverTemperatureDependence

Returns the type of temperature dependence used for the analysis.

long St7GetSolverTemperatureDependence(long uID, long* TempType)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
TempType
Temperature dependence type; either tdNone or tdCombined.

Applicability
Applicable to quasi-static, nonlinear static and nonlinear transient dynamic analysis.
