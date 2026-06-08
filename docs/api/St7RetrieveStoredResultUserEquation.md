# St7RetrieveStoredResultUserEquation

Retrieves a stored user defined equation.

long St7RetrieveStoredResultUserEquation(long uID, long Entity, long Number,

char* Name, char* Equation, long MaxStringLen, long* TrigType)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyBEAM, tyPLATE or tyBRICK.

Number

User defined equation number for the specified entity.

MaxStringLen

Maximum number of characters allocated for each of Name and Equation.

Output Parameters

Name

Name of the user defined equation.

Equation

User defined equation as a character array. See User Defined Results for additional information.

Results

TrigType

Type of angle arguments; either auRadian or auDegree.
