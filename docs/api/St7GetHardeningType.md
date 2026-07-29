# St7GetHardeningType

Returns the hardening model used for the specified property.

long St7GetHardeningType(long uID, long Entity, long PropNum, long* HardType)
Input Parameters
uID
Strand7 model file ID.
Entity
Property type; only ptBEAMPROP is valid.
PropNum
Property number.
Output Parameters
HardType
One of htIsotropic, htKinematic or htTakeda.
