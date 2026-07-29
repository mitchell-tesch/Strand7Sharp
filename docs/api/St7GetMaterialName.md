# St7GetMaterialName

Returns the name of the material referenced by the specified property.

long St7GetMaterialName(long uID, long Entity, long PropNum, char* MaterialName,
long MaxStringLen)
Input Parameters
uID
Strand7 model file ID.
Entity
One of ptBEAMPROP, ptPLATEPROP, ptBRICKPROP or ptPLYPROP.
PropNum
Property number.
MaxStringLen
Maximum number of characters allocated for MaterialName.
Output Parameters
MaterialName
Name of the material.
