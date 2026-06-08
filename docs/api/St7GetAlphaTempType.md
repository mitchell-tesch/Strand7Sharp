# St7GetAlphaTempType

Returns the type of thermal expansion table assigned to the specified property.

long St7GetAlphaTempType(long uID, long Entity, long PropNum,

long* AlphaTempType)

Input Parameters

uID

Strand7 model file ID.

Entity

One of ptBEAMPROP, ptPLATEPROP or ptBRICKPROP.

PropNum

Property number.

Output Parameters
AlphaTempType

Table type; either atIntegrated or atInstantaneous.
