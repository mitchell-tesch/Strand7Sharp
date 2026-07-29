# St7GetNumStoredResultUserEquations

Returns the number of stored user defined equations.

long St7GetNumStoredResultUserEquations(long uID, long Entity,
long* NumEquations)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyBEAM, tyPLATE or tyBRICK.
Output Parameters
NumEquations
Number of stored user defined equations for the specified entity.
