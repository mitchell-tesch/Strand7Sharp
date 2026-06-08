# St7GetPropertyName

Returns the name of the specified property.

long St7GetPropertyName(long uID, long Entity, long PropNum, char* PropName,

long MaxStringLen)

Input Parameters

uID

Strand7 model file ID.

Entity

One of ptBEAMPROP, ptPLATEPROP, ptBRICKPROP or ptPLYPROP.

PropNum

Property number.

MaxStringLen

Maximum number of characters allocated for PropName.

Output Parameters
PropName

Name of the property.

Properties – Beams, Plates and Bricks
