# St7GetTransientTemperatureInputType

Returns the type of temperature data to be used for quasi-static and nonlinear transient dynamic analysis.

long St7GetTransientTemperatureInputType(long uID, long* InputType)

Input Parameters

uID

Strand7 model file ID.

Output Parameters
InputType

Temperature type; either ttFromFile or ttNodalTemp.
