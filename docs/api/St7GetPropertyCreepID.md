# St7GetPropertyCreepID

Returns the creep definition of the specified property.

long St7GetPropertyCreepID(long uID, long Entity, long PropNum, long* CreepID)
Input Parameters
uID
Strand7 model file ID.
Entity
One of ptBEAMPROP, ptPLATEPROP or ptBRICKPROP.
PropNum
Property number.
Output Parameters
CreepID
Creep layout ID or 0 for none.
