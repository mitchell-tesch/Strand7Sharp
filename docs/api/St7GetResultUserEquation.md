# St7GetResultUserEquation

Returns the currently active user defined equation for beam, plate or brick results. The calculated results can be
accessed via the functions St7GetBeamResultArray, St7GetPlateResultArray and St7GetBrickResultArray,
respectively.

long St7GetResultUserEquation(long uID, long Entity, char* Equation,
long MaxStringLen, long* TrigType)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyBEAM, tyPLATE or tyBRICK.
MaxStringLen
Maximum number of characters allocated for Equation.
Output Parameters
Equation
User defined equation as a character array. See User Defined Results for additional information.
TrigType
Type of angle arguments; either auRadian or auDegree.
