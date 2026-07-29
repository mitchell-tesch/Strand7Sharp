# St7SetAlphaTempType

Sets the thermal expansion table type for the specified property.

long St7SetAlphaTempType(long uID, long Entity, long PropNum, long AlphaTempType)
Input Parameters
uID
Strand7 model file ID.
Entity
One of ptBEAMPROP, ptPLATEPROP or ptBRICKPROP.
PropNum
Property number.
AlphaTempType
Table type; either atIntegrated or atInstantaneous.
