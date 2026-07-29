# St7SetMaterialName

Sets the name of the material referenced by the specified property.

long St7SetMaterialName(long uID, long Entity, long PropNum, char* MaterialName)
Input Parameters
uID
Strand7 model file ID.
Entity
One of ptBEAMPROP, ptPLATEPROP, ptBRICKPROP or ptPLYPROP.
PropNum
Property number.
MaterialName
Name of the material.
