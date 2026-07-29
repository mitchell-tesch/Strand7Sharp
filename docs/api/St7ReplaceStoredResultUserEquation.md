# St7ReplaceStoredResultUserEquation

Replaces a stored user defined equation.

long St7ReplaceStoredResultUserEquation(long uID, long Entity, long Number,
char* Name, char* Equation, long TrigType)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyBEAM, tyPLATE or tyBRICK.
Number
User defined equation number for the specified entity.
Name
Name of the user defined equation.
Equation
User defined equation as a character array. See User Defined Results for additional information.
TrigType
Type of angle arguments; either auRadian or auDegree.
