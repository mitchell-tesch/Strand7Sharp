# St7SetResultUserEquation

Assigns a user defined equation for beam, plate or brick results and sets this as the currently active equation. The
calculated results can be accessed via the St7GetBeamResultArray, St7GetPlateResultArray and
St7GetBrickResultArray functions, respectively.

long St7SetResultUserEquation(long uID, long Entity, char* Equation,

long TrigType)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyBEAM, tyPLATE or tyBRICK.

Equation

User defined equation as a character array. See User Defined Results for additional information.

TrigType

Type of angle arguments; either auRadian or auDegree.
