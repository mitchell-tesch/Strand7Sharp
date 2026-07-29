# St7GetTimeDependentModType

Returns the type of temperature/time dependence assigned to the specified property. This setting controls the
scaling used to update the material modulus values. This option is only used when an associated Factor vs
Temperature/Time table is assigned to the specified property.

long St7GetTimeDependentModType(long uID, long Entity, long PropNum,
long* ModType)
Input Parameters
uID
Strand7 model file ID.
Entity
One of ptBEAMPROP, ptPLATEPROP or ptBRICKPROP.
PropNum
Property number.
Output Parameters
ModType
Type of temperature/time dependence; either mtElastic or mtPlastic.
