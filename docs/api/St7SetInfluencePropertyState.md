# St7SetInfluencePropertyState

Includes or excludes a property from load influence combinations.

long St7SetInfluencePropertyState(long uID, long Entity, long PropNum,

bool Included)

Input Parameters

uID

Strand7 model file ID.

Entity

One of ptBEAMPROP, ptPLATEPROP or ptBRICKPROP.

PropNum

Property number.

Included

True if the property is to be included.
