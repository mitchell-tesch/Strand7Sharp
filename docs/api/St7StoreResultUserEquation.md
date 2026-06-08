# St7StoreResultUserEquation

Stores a user defined equation.

long St7StoreResultUserEquation(long uID, long Entity, char* Name,

char* Equation, long TrigType)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyBEAM, tyPLATE or tyBRICK.

Name

Name of the user defined equation.

Equation

User defined equation as a character array. See User Defined Results for additional information.

TrigType

Type of angle arguments; either auRadian or auDegree.
